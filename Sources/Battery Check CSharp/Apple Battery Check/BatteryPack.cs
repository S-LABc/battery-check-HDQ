using Apple_Battery_Check.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apple_Battery_Check
{
    public class BatteryPack
    {
        private string[] _veri;

        public BatteryPack()
        {
            _veri = new string[55]; // Varsayılan değerlerle diziyi oluşturabilirsiniz
        }

        public void UpdateData(string gelenVeri)
        {
            _veri = gelenVeri.Split(Settings.Default.SEPARATOR_SLASH);
            VerileriIsle();
        }

        public string Control { get; private set; }
        public string AtRate { get; private set; }
        public string UnfilteredSOC { get; private set; }
        public double TemperatureKelvin { get; private set; }
        public double TemperatureCelsius { get; private set; }
        public double TemperatureFahrenheit { get; private set; }
        public int Voltage { get; private set; }
        public string Flags { get; private set; }
        public int NomAvailableCapacity { get; private set; }
        public int FullAvailableCapacity { get; private set; }
        public int RemainingCapacity { get; private set; }
        public int FullChargeCapacity { get; private set; }
        public double AverageCurrent { get; private set; } // - discharge + charge
        public int TimeToEmpty { get; private set; }
        public int FullChargeCapacityFiltered { get; private set; }
        public int SafetyStatus { get; private set; }
        public int FullChargeCapacityUnfiltered { get; private set; }
        public double Imax { get; private set; }
        public int RemainingCapacityUnflitered { get; private set; }
        public int RemainingCapacityFiltered { get; private set; }
        public int BTPSOC1Set { get; private set; }
        public int BTPSOC1Clear { get; private set; }
        public double InternalTemperatureKelvin { get; private set; }
        public double InternalTemperatureCelsius { get; private set; }
        public double InternalTemperatureFahrenheit { get; private set; }
        public string CycleCount { get; private set; }
        public string StateOfCharge { get; private set; }
        public string StateOfHealth { get; private set; }
        public int ChargingVoltage { get; private set; }
        public double ChargingCurrent { get; private set; }
        public double PassedCharge { get; private set; }
        public string DOD0 { get; private set; }
        public double SelfDischargeCurrent { get; private set; }
        //extended commands can be direct read
        public string PackConfiguration { get; private set; }
        public string DesignCapacity { get; private set; }
        public string DODatEOC { get; private set; }
        public string Qstart { get; private set; }
        public string FastQmax { get; private set; }
        public string Reserved2 { get; private set; }
        public string Reserved3 { get; private set; }
        public string Reserved4 { get; private set; }
        public string AveragePower { get; private set; }

        //control commands 
        public string ControlStatus { get; private set; }
        public string DeviceType { get; private set; }
        public string FirmwareVersion { get; private set; }
        public string HardwareVersion { get; private set; }
        public string RESET_DATA { get; private set; }
        public string PREV_MACWRITE { get; private set; }
        public string CHEM_ID { get; private set; }
        public string DF_VERSION { get; private set; }
        public string ALL_DF_CHKSUM { get; private set; }
        public string STATIC_DF_CHKSUM { get; private set; }
        public string OFFSET_CAL { get; private set; }


        //flash block commands is sub command of extended commands
        public string ManufacturerBlockA { get; private set; }
        public string ManufacturerBlockB { get; private set; }
        public string ManufacturerBlockC { get; private set; }
        public string Checksum { get; private set; }

        private void VerileriIsle()
        {
            Control = "0x" + _veri[0].ToUpper();
            AtRate = _veri[1];
            UnfilteredSOC = _veri[2];
            TemperatureKelvin = Convert.ToDouble(_veri[3]) * Settings.Default.DECIMAL_FACTOR;
            TemperatureCelsius = TemperatureKelvin - Settings.Default.CELSIUS_OFFSET;
            TemperatureFahrenheit = TemperatureCelsius * 1.8 + 32;
            Voltage = Convert.ToInt32(_veri[4]);
            Flags = "0x" + _veri[5].ToUpper();
            NomAvailableCapacity = Convert.ToInt32(_veri[6]);
            FullAvailableCapacity = Convert.ToInt32(_veri[7]);
            RemainingCapacity = Convert.ToInt32(_veri[8]);
            FullChargeCapacity = Convert.ToInt32(_veri[9]);
            AverageCurrent = Convert.ToInt32(_veri[10]);
            TimeToEmpty = Convert.ToInt32(_veri[11]);
            FullChargeCapacityFiltered = Convert.ToInt32(_veri[12]);
            SafetyStatus = Convert.ToInt32(_veri[13]);
            FullChargeCapacityUnfiltered = Convert.ToInt32(_veri[14]);
            Imax = Convert.ToInt32(_veri[15]);
            RemainingCapacityUnflitered = Convert.ToInt32(_veri[16]);
            RemainingCapacityFiltered = Convert.ToInt32(_veri[17]);
            BTPSOC1Set = Convert.ToInt32(_veri[18]);
            BTPSOC1Clear = Convert.ToInt32(_veri[19]);
            InternalTemperatureKelvin = Convert.ToInt32(_veri[20]);
            CycleCount = _veri[21];
            StateOfCharge = _veri[22];
            StateOfHealth = _veri[23];
            ChargingVoltage = Convert.ToInt32(_veri[24]);
            ChargingCurrent = Convert.ToInt32(_veri[25]);
            PassedCharge = Convert.ToInt32(_veri[26]);
            DOD0 = "0x" + _veri[27].ToUpper();
            SelfDischargeCurrent = Convert.ToInt32(_veri[28]);

            PackConfiguration = "0x" + _veri[29].ToUpper();
            DesignCapacity = _veri[30];
            DODatEOC = _veri[31];
            Qstart = _veri[32];
            FastQmax = _veri[33];
            Reserved2 = _veri[34];
            Reserved3 = _veri[35];
            Reserved4 = _veri[36];
            AveragePower = _veri[37];

            ControlStatus = "0x" + _veri[38].ToUpper();
            DeviceType = Resources.PREFIX_CONTROLLER + _veri[39].ToUpper();
            FirmwareVersion = _veri[40].Insert(1, Settings.Default.SEPARATOR_DOT);
            HardwareVersion = Convert.ToInt32(_veri[41].ToUpper(), 16).ToString().Insert(1, Settings.Default.SEPARATOR_DOT);
            RESET_DATA = _veri[42];
            PREV_MACWRITE = _veri[43];
            CHEM_ID = _veri[44];
            DF_VERSION = _veri[45];
            ALL_DF_CHKSUM = _veri[46];
            STATIC_DF_CHKSUM = _veri[47];
            OFFSET_CAL = _veri[48];

            ManufacturerBlockA = _veri[49];//bu bloklar null terminated döner uzunluklar sabit değildir
            ManufacturerBlockB = _veri[50];
            ManufacturerBlockC = _veri[51];

        }
    }

}
