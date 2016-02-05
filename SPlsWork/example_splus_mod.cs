using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_EXAMPLE_SPLUS_MOD
{
    public class UserModuleClass_EXAMPLE_SPLUS_MOD : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput BUTTON_1;
        Crestron.Logos.SplusObjects.DigitalInput BUTTON_2;
        Crestron.Logos.SplusObjects.DigitalOutput BTNFB1;
        Crestron.Logos.SplusObjects.DigitalOutput BTNFB2;
        
        public override void LogosSplusInitialize()
        {
            SocketInfo __socketinfo__ = new SocketInfo( 1, this );
            InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
            _SplusNVRAM = new SplusNVRAM( this );
            
            BUTTON_1 = new Crestron.Logos.SplusObjects.DigitalInput( BUTTON_1__DigitalInput__, this );
            m_DigitalInputList.Add( BUTTON_1__DigitalInput__, BUTTON_1 );
            
            BUTTON_2 = new Crestron.Logos.SplusObjects.DigitalInput( BUTTON_2__DigitalInput__, this );
            m_DigitalInputList.Add( BUTTON_2__DigitalInput__, BUTTON_2 );
            
            BTNFB1 = new Crestron.Logos.SplusObjects.DigitalOutput( BTNFB1__DigitalOutput__, this );
            m_DigitalOutputList.Add( BTNFB1__DigitalOutput__, BTNFB1 );
            
            BTNFB2 = new Crestron.Logos.SplusObjects.DigitalOutput( BTNFB2__DigitalOutput__, this );
            m_DigitalOutputList.Add( BTNFB2__DigitalOutput__, BTNFB2 );
            
            
            
            _SplusNVRAM.PopulateCustomAttributeList( true );
            
            NVRAM = _SplusNVRAM;
            
        }
        
        public override void LogosSimplSharpInitialize()
        {
            
            
        }
        
        public UserModuleClass_EXAMPLE_SPLUS_MOD ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
        
        
        
        
        const uint BUTTON_1__DigitalInput__ = 0;
        const uint BUTTON_2__DigitalInput__ = 1;
        const uint BTNFB1__DigitalOutput__ = 0;
        const uint BTNFB2__DigitalOutput__ = 1;
        
        [SplusStructAttribute(-1, true, false)]
        public class SplusNVRAM : SplusStructureBase
        {
        
            public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
            
            
        }
        
        SplusNVRAM _SplusNVRAM = null;
        
        public class __CEvent__ : CEvent
        {
            public __CEvent__() {}
            public void Close() { base.Close(); }
            public int Reset() { return base.Reset() ? 1 : 0; }
            public int Set() { return base.Set() ? 1 : 0; }
            public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
        }
        public class __CMutex__ : CMutex
        {
            public __CMutex__() {}
            public void Close() { base.Close(); }
            public void ReleaseMutex() { base.ReleaseMutex(); }
            public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
        }
         public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
    }
    
    
}
