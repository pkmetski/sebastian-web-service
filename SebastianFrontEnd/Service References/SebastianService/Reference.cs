﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SebastianFrontEnd.SebastianService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Airport", Namespace="http://schemas.datacontract.org/2004/07/SebastianWS.DTO")]
    [System.SerializableAttribute()]
    public partial class Airport : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Schedule", Namespace="http://schemas.datacontract.org/2004/07/SebastianWS.DTO")]
    [System.SerializableAttribute()]
    public partial class Schedule : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SebastianFrontEnd.SebastianService.Flight[] FlightsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SebastianFrontEnd.SebastianService.Flight[] Flights {
            get {
                return this.FlightsField;
            }
            set {
                if ((object.ReferenceEquals(this.FlightsField, value) != true)) {
                    this.FlightsField = value;
                    this.RaisePropertyChanged("Flights");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Flight", Namespace="http://schemas.datacontract.org/2004/07/SebastianWS.DTO")]
    [System.SerializableAttribute()]
    public partial class Flight : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ArrivalTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AvailableSeatsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DepartureTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FlightIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SebastianFrontEnd.SebastianService.Airport FromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SebastianFrontEnd.SebastianService.Airport ToField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ArrivalTime {
            get {
                return this.ArrivalTimeField;
            }
            set {
                if ((this.ArrivalTimeField.Equals(value) != true)) {
                    this.ArrivalTimeField = value;
                    this.RaisePropertyChanged("ArrivalTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AvailableSeats {
            get {
                return this.AvailableSeatsField;
            }
            set {
                if ((this.AvailableSeatsField.Equals(value) != true)) {
                    this.AvailableSeatsField = value;
                    this.RaisePropertyChanged("AvailableSeats");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DepartureTime {
            get {
                return this.DepartureTimeField;
            }
            set {
                if ((this.DepartureTimeField.Equals(value) != true)) {
                    this.DepartureTimeField = value;
                    this.RaisePropertyChanged("DepartureTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FlightId {
            get {
                return this.FlightIdField;
            }
            set {
                if ((this.FlightIdField.Equals(value) != true)) {
                    this.FlightIdField = value;
                    this.RaisePropertyChanged("FlightId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SebastianFrontEnd.SebastianService.Airport From {
            get {
                return this.FromField;
            }
            set {
                if ((object.ReferenceEquals(this.FromField, value) != true)) {
                    this.FromField = value;
                    this.RaisePropertyChanged("From");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SebastianFrontEnd.SebastianService.Airport To {
            get {
                return this.ToField;
            }
            set {
                if ((object.ReferenceEquals(this.ToField, value) != true)) {
                    this.ToField = value;
                    this.RaisePropertyChanged("To");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SebastianService.ISebastianWS")]
    public interface ISebastianWS {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISebastianWS/GetAllAirports", ReplyAction="http://tempuri.org/ISebastianWS/GetAllAirportsResponse")]
        SebastianFrontEnd.SebastianService.Airport[] GetAllAirports();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISebastianWS/GetSchedule", ReplyAction="http://tempuri.org/ISebastianWS/GetScheduleResponse")]
        SebastianFrontEnd.SebastianService.Schedule GetSchedule(SebastianFrontEnd.SebastianService.Airport airport);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISebastianWS/BookFlight", ReplyAction="http://tempuri.org/ISebastianWS/BookFlightResponse")]
        bool BookFlight(SebastianFrontEnd.SebastianService.Flight flight);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISebastianWSChannel : SebastianFrontEnd.SebastianService.ISebastianWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SebastianWSClient : System.ServiceModel.ClientBase<SebastianFrontEnd.SebastianService.ISebastianWS>, SebastianFrontEnd.SebastianService.ISebastianWS {
        
        public SebastianWSClient() {
        }
        
        public SebastianWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SebastianWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SebastianWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SebastianWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SebastianFrontEnd.SebastianService.Airport[] GetAllAirports() {
            return base.Channel.GetAllAirports();
        }
        
        public SebastianFrontEnd.SebastianService.Schedule GetSchedule(SebastianFrontEnd.SebastianService.Airport airport) {
            return base.Channel.GetSchedule(airport);
        }
        
        public bool BookFlight(SebastianFrontEnd.SebastianService.Flight flight) {
            return base.Channel.BookFlight(flight);
        }
    }
}