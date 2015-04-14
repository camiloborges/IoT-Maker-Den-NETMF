//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HyrdaDen {

    using Gadgeteer;
    using GTM = Gadgeteer.Modules;
    
    
    public partial class Program : Gadgeteer.Program {
        
        /// <summary>The LightSense module using socket 14 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.LightSense lightSense;
        
        /// <summary>The Ethernet ENC28 module using socket 3 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.EthernetENC28 ethernetENC28;
        
        /// <summary>The Temp&Humidity module using socket 8 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.TempHumidity tempHumidity;
        
        /// <summary>The Relay X1 module using socket 6 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.RelayX1 relayX1;
        
        /// <summary>The LED7R module using socket 13 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.LED7R led7R;
        
        /// <summary>This property provides access to the Mainboard API. This is normally not necessary for an end user program.</summary>
        protected new static GHIElectronics.Gadgeteer.FEZHydra Mainboard {
            get {
                return ((GHIElectronics.Gadgeteer.FEZHydra)(Gadgeteer.Program.Mainboard));
            }
            set {
                Gadgeteer.Program.Mainboard = value;
            }
        }
        
        /// <summary>This method runs automatically when the device is powered, and calls ProgramStarted.</summary>
        public static void Main() {
            // Important to initialize the Mainboard first
            Program.Mainboard = new GHIElectronics.Gadgeteer.FEZHydra();
            Program p = new Program();
            p.InitializeModules();
            p.ProgramStarted();
            // Starts Dispatcher
            p.Run();
        }
        
        private void InitializeModules() {
            this.lightSense = new GTM.GHIElectronics.LightSense(14);
            this.ethernetENC28 = new GTM.GHIElectronics.EthernetENC28(3);
            this.tempHumidity = new GTM.GHIElectronics.TempHumidity(8);
            this.relayX1 = new GTM.GHIElectronics.RelayX1(6);
            this.led7R = new GTM.GHIElectronics.LED7R(13);
        }
    }
}
