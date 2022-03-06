using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gorkido_s_GT_Unbanner
{
    public partial class Unbanner_Form : Form
    {
        public Unbanner_Form()
        {
            InitializeComponent();
        }

        private readonly string NewLine = Environment.NewLine; // New line string
        private readonly System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer(); // New timer

        #region Design Stuff
        private async void Exit_Click(object sender, System.EventArgs e)
        {
            for (Opacity = 0.90; Opacity > .0; Opacity -= .1) { await System.Threading.Tasks.Task.Delay(10); } // Exiting transition
            Application.Exit();
        }

        private void Minimize_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Unbanner
        private void Unban_Click(object sender, System.EventArgs e)
        {
            try
            {
                UpdateAddresses();
                RefreshKeys(); // Refresh all needed keys
                System.Threading.Thread.Sleep(500);
                if (longkey.Text != "None" && shortkey.Text != "None")
                { // If longkey and shortkey doesn't exist, show an error message
                    UnbanLog.Clear();
                    Title.Focus();
                    if (!Adapter.IsValidMac(CurrentMacTextBox.Text, false))
                    {
                        MessageBox.Show("Entered MAC-address is not valid; will not update.", "Invalid MAC-address specified", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    SetRegistryMac(CurrentMacTextBox.Text);
                    UnbanLog.Text += "->Mac Adress Randomized And Changed!";
                    Registry.CurrentUser.DeleteSubKey(longkey.Text); // Delete longkey
                    UnbanLog.Text += NewLine + "->The Second Key " + longkey.Text + " is deleted!";
                    string ShortKeyStr = @"Software\Microsoft\" + shortkey.Text; // shortkey
                    Registry.CurrentUser.DeleteSubKey(ShortKeyStr); // Delete shortkey
                    UnbanLog.Text += NewLine + "->The First Key " + shortkey.Text + " is deleted!";
                    string CryptographyKey = @"SOFTWARE\Microsoft\Cryptography"; // Cryptography Key
                    RegistryKey ckey = Registry.LocalMachine.OpenSubKey(CryptographyKey, true);
                    ckey.DeleteValue("MachineGuid");// Delete Cryptography Key
                    UnbanLog.Text += NewLine + "->The MachineGuid key is deleted!" + NewLine + "->Done Unbanning!";
                }
                else
                {
                    UnbanLog.Text += NewLine + "->Can't UNBAN! Open Growtopia and click 'Connect'. Then Click 'REFRESH'";
                    MessageBox.Show("                                                Can't UNBAN!                                                          Tip: Open Growtopia and click 'Connect'. Then Restart the Trainer!");
                }
            }
            catch (Exception) { }
        }

        private void RefreshKeys()
        {
            foreach (string subkeyname in Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Microsoft").GetSubKeyNames())
            {
                if (subkeyname.StartsWith("1") || subkeyname.StartsWith("2") || subkeyname.StartsWith("3") || subkeyname.StartsWith("4") || subkeyname.StartsWith("5") || subkeyname.StartsWith("6") || subkeyname.StartsWith("7") || subkeyname.StartsWith("8") || subkeyname.StartsWith("9"))
                { // If subkeyname string starts with "1, 2, 3, 4, 5, 6, 7, 8, 9", type if its found or not
                    shortkey.Text = subkeyname;
                    break;
                }
                else
                {
                    longkey.Text = "None";
                    break;
                }
            }
            foreach (string subkeyname2 in Registry.CurrentUser.GetSubKeyNames())
            { // If subkeyname2 string starts with "1, 2, 3, 4, 5, 6, 7, 8, 9", type if its found or not
                if (subkeyname2.StartsWith("1") || subkeyname2.StartsWith("2") || subkeyname2.StartsWith("3") || subkeyname2.StartsWith("4") || subkeyname2.StartsWith("5") || subkeyname2.StartsWith("6") || subkeyname2.StartsWith("7") || subkeyname2.StartsWith("8") || subkeyname2.StartsWith("9"))
                {
                    longkey.Text = subkeyname2;
                    break;
                }
                else
                {
                    longkey.Text = "None";
                    break;
                }
            }
        }

        private void SetRegistryMac(string mac)
        { // Change adapter
            Adapter a = AdaptersComboBox.SelectedItem as Adapter;
            if (a.SetRegistryMac(mac))
            {
                System.Threading.Thread.Sleep(100);
                UpdateAddresses();
            }
        }

        private void UpdateAddresses()
        {
            Adapter a = AdaptersComboBox.SelectedItem as Adapter;
            CurrentMacTextBox.Text = a.RegistryMac;
            ActualMacLabel.Text = a.Mac;
        }

        public class Adapter
        {
            public ManagementObject adapter;
            public string adaptername;
            public string customname;
            public int devnum;

            public Adapter(ManagementObject a, string aname, string cname, int n)
            {
                adapter = a;
                adaptername = aname;
                customname = cname;
                devnum = n;
            }

            public Adapter(NetworkInterface i) : this(i.Description)
            {
            }

            public Adapter(string aname)
            {
                adaptername = aname;

                ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from win32_networkadapter where Name='" + adaptername + "'");
                ManagementObjectCollection found = searcher.Get();
                adapter = found.Cast<ManagementObject>().FirstOrDefault();
                try
                {
                    Match match = Regex.Match(adapter.Path.RelativePath, "\\\"(\\d+)\\\"$");
                    devnum = int.Parse(match.Groups[1].Value);
                }
                catch
                {
                    return;
                }

                customname = NetworkInterface.GetAllNetworkInterfaces().Where(
                  i => i.Description == adaptername
                ).Select(
                  i => " (" + i.Name + ")"
                ).FirstOrDefault();
            }

            public string Mac
            {
                get
                {
                    try
                    {
                        return BitConverter.ToString(ManagedAdapter.GetPhysicalAddress().GetAddressBytes()).Replace("-", "").ToUpper();
                    }
                    catch
                    {
                        return null;
                    }
                }
            }

            public NetworkInterface ManagedAdapter => NetworkInterface.GetAllNetworkInterfaces().Where(nic => nic.Description == adaptername).FirstOrDefault();

            public string RegistryKey => string.Format(@"SYSTEM\ControlSet001\Control\Class\{{4D36E972-E325-11CE-BFC1-08002BE10318}}\{0:D4}", devnum);

            public string RegistryMac
            {
                get
                {
                    try
                    {
                        using (RegistryKey regkey = Registry.LocalMachine.OpenSubKey(RegistryKey, false))
                        {
                            return regkey.GetValue("NetworkAddress").ToString();
                        }
                    }
                    catch
                    {
                        return null;
                    }
                }
            }

            public static string GetNewMac()
            {
                System.Random r = new System.Random();

                byte[] bytes = new byte[6];
                r.NextBytes(bytes);

                bytes[0] = (byte)(bytes[0] | 0x02);

                bytes[0] = (byte)(bytes[0] & 0xfe);

                return MacToString(bytes);
            }

            public static bool IsValidMac(string mac, bool actual)
            {
                if (mac.Length != 12)
                {
                    return false;
                }

                if (mac != mac.ToUpper())
                {
                    return false;
                }

                if (!Regex.IsMatch(mac, "^[0-9A-F]*$"))
                {
                    return false;
                }

                if (actual)
                {
                    return true;
                }

                char c = mac[1];
                return (c == '2' || c == '6' || c == 'A' || c == 'E');
            }

            public static bool IsValidMac(byte[] bytes, bool actual)
            {
                return IsValidMac(Adapter.MacToString(bytes), actual);
            }

            public static string MacToString(byte[] bytes)
            {
                return BitConverter.ToString(bytes).Replace("-", "").ToUpper();
            }

            public bool SetRegistryMac(string value)
            {
                bool shouldReenable = false;

                try
                {
                    if (value.Length > 0 && !Adapter.IsValidMac(value, false))
                    {
                        throw new Exception(value + " is not a valid mac address");
                    }

                    using (RegistryKey regkey = Registry.LocalMachine.OpenSubKey(RegistryKey, true))
                    {
                        if (regkey == null)
                        {
                            throw new Exception("Failed to open the registry key");
                        }

                        if (regkey.GetValue("AdapterModel") as string != adaptername &&
                          regkey.GetValue("DriverDesc") as string != adaptername)
                        {
                            throw new Exception("Adapter not found in registry");
                        }

                        uint result = (uint)adapter.InvokeMethod("Disable", null);
                        if (result != 0)
                        {
                            throw new Exception("Failed to disable network adapter.");
                        }

                        shouldReenable = true;

                        if (value.Length > 0)
                        {
                            regkey.SetValue("NetworkAddress", value, RegistryValueKind.String);
                        }
                        else
                        {
                            regkey.DeleteValue("NetworkAddress");
                        }

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
                finally
                {
                    if (shouldReenable)
                    {
                        uint result = (uint)adapter.InvokeMethod("Enable", null);
                        if (result != 0)
                        {
                            MessageBox.Show("Failed to re-enable network adapter.");
                        }
                    }
                }
            }

            public override string ToString()
            {
                return adaptername + customname;
            }
        }
        #endregion

        #region Remove Guna Files And Registry Keys
        private void RemoveGuna()
        { // Removing Guna licensing stuff
            string Guna = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.guna"; // Get guna path
            try
            {
                if (Directory.Exists(Guna)) // If guna folder exists, delete it
                {
                    Directory.Delete(Guna, true);
                }
                using (RegistryKey Key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    Key.DeleteSubKeyTree("SOFTWARE\\Guna"); // Delete Guna key
                }
            }
            catch (Exception) { }
        }
        #endregion

        private void FadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 0.90) // Increasing the opacity until 0.90
            {
                t1.Stop();   // This stops the timer if the form is completely displayed
            }
            else
            {
                Opacity += 0.05; // Increasing the opacity
            }
        }

        private void StartForm()
        {
            Opacity = 0; // First the opacity is 0
            t1.Interval = 10;  // We'll increase the opacity every 10ms
            t1.Tick += new EventHandler(FadeIn);  // This calls the function that changes opacity
            t1.Start(); // Starting the timer
        }

        private void Unbanner_Form_Load(object sender, EventArgs e)
        {
            Show();
            StartForm();
            RemoveGuna();

            #region Startup Transitions
            Startup_Transition.Show(TopBar);
            Startup_Transition.Show(Unban);
            Startup_Transition.Show(UnbanLog);
            Startup_Transition.Show(AdaptersComboBox);
            #endregion

            #region Refresh key info

            try
            {
                foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces().Where(a => Adapter.IsValidMac(a.GetPhysicalAddress().GetAddressBytes(), true)).OrderByDescending(a => a.Speed))
                { // Add all adapters in the combobox
                    AdaptersComboBox.Items.Add(new Adapter(adapter));
                }
                AdaptersComboBox.SelectedIndex = 0; // Select the first one
                foreach (string subkeyname2 in Registry.CurrentUser.GetSubKeyNames())
                {
                    if (subkeyname2.StartsWith("1") || subkeyname2.StartsWith("2") || subkeyname2.StartsWith("3") || subkeyname2.StartsWith("4") || subkeyname2.StartsWith("5") || subkeyname2.StartsWith("6") || subkeyname2.StartsWith("7") || subkeyname2.StartsWith("8") || subkeyname2.StartsWith("9"))
                    { // If subkeyname2 string starts with "1, 2, 3, 4, 5, 6, 7, 8, 9", type if its found or not
                        longkey.Text = subkeyname2;
                        UnbanLog.Text = "->The Second Key " + longkey.Text + " is found!";
                        break;
                    }
                    else
                    {
                        longkey.Text = "None";
                        UnbanLog.Text = "->Second Key Cannot be found!";
                        break;
                    }
                }
                foreach (string subkeyname in Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Microsoft").GetSubKeyNames())
                {
                    if (subkeyname.StartsWith("1") || subkeyname.StartsWith("2") || subkeyname.StartsWith("3") || subkeyname.StartsWith("4") || subkeyname.StartsWith("5") || subkeyname.StartsWith("6") || subkeyname.StartsWith("7") || subkeyname.StartsWith("8") || subkeyname.StartsWith("9"))
                    { // If subkeyname string starts with "1, 2, 3, 4, 5, 6, 7, 8, 9", type if its found or not
                        shortkey.Text = subkeyname;
                        UnbanLog.Text += NewLine + "->The First Key " + shortkey.Text + " is found!";
                        break;
                    }
                    else
                    {
                        shortkey.Text = "None";
                        UnbanLog.Text += NewLine + "->First Key Cannot be found!";
                        break;
                    }
                }
            }
            catch (Exception) { }

            #endregion Refresh key info

            RegistryKey Cryptography = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Cryptography", true);
            if (Cryptography.GetValueNames().Contains("MachineGuid"))
            { // Check if MachineGuid key exists
                UnbanLog.Text += NewLine + "->MachineGuid Key Is Found!";
            }
            else
            {
                UnbanLog.Text += NewLine + "->MachineGuid Key Cannot Be Found!";
            }
        }
    }
}
