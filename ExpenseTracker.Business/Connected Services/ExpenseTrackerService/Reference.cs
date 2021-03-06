﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpenseTrackerWeb.Business.ExpenseTrackerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TransactionDTO", Namespace="http://schemas.datacontract.org/2004/07/ExpenseTracker.BusinessObjects")]
    [System.SerializableAttribute()]
    public partial class TransactionDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool HasReceiptsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TransactionAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionCategoryDTO TransactionCategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TransactionDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TransactionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TransactionNoteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionReceiptDTO[] TransactionReceiptsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
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
        public int CategoryId {
            get {
                return this.CategoryIdField;
            }
            set {
                if ((this.CategoryIdField.Equals(value) != true)) {
                    this.CategoryIdField = value;
                    this.RaisePropertyChanged("CategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool HasReceipts {
            get {
                return this.HasReceiptsField;
            }
            set {
                if ((this.HasReceiptsField.Equals(value) != true)) {
                    this.HasReceiptsField = value;
                    this.RaisePropertyChanged("HasReceipts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double TransactionAmount {
            get {
                return this.TransactionAmountField;
            }
            set {
                if ((this.TransactionAmountField.Equals(value) != true)) {
                    this.TransactionAmountField = value;
                    this.RaisePropertyChanged("TransactionAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionCategoryDTO TransactionCategory {
            get {
                return this.TransactionCategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.TransactionCategoryField, value) != true)) {
                    this.TransactionCategoryField = value;
                    this.RaisePropertyChanged("TransactionCategory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TransactionDate {
            get {
                return this.TransactionDateField;
            }
            set {
                if ((this.TransactionDateField.Equals(value) != true)) {
                    this.TransactionDateField = value;
                    this.RaisePropertyChanged("TransactionDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TransactionId {
            get {
                return this.TransactionIdField;
            }
            set {
                if ((this.TransactionIdField.Equals(value) != true)) {
                    this.TransactionIdField = value;
                    this.RaisePropertyChanged("TransactionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TransactionNote {
            get {
                return this.TransactionNoteField;
            }
            set {
                if ((object.ReferenceEquals(this.TransactionNoteField, value) != true)) {
                    this.TransactionNoteField = value;
                    this.RaisePropertyChanged("TransactionNote");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionReceiptDTO[] TransactionReceipts {
            get {
                return this.TransactionReceiptsField;
            }
            set {
                if ((object.ReferenceEquals(this.TransactionReceiptsField, value) != true)) {
                    this.TransactionReceiptsField = value;
                    this.RaisePropertyChanged("TransactionReceipts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TransactionCategoryDTO", Namespace="http://schemas.datacontract.org/2004/07/ExpenseTracker.BusinessObjects")]
    [System.SerializableAttribute()]
    public partial class TransactionCategoryDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryNameField;
        
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
        public int CategoryId {
            get {
                return this.CategoryIdField;
            }
            set {
                if ((this.CategoryIdField.Equals(value) != true)) {
                    this.CategoryIdField = value;
                    this.RaisePropertyChanged("CategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CategoryName {
            get {
                return this.CategoryNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryNameField, value) != true)) {
                    this.CategoryNameField = value;
                    this.RaisePropertyChanged("CategoryName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TransactionReceiptDTO", Namespace="http://schemas.datacontract.org/2004/07/ExpenseTracker.BusinessObjects")]
    [System.SerializableAttribute()]
    public partial class TransactionReceiptDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ReceiptImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TransactionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TransactionReceiptIdField;
        
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
        public string ContentType {
            get {
                return this.ContentTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentTypeField, value) != true)) {
                    this.ContentTypeField = value;
                    this.RaisePropertyChanged("ContentType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] ReceiptImage {
            get {
                return this.ReceiptImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ReceiptImageField, value) != true)) {
                    this.ReceiptImageField = value;
                    this.RaisePropertyChanged("ReceiptImage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TransactionId {
            get {
                return this.TransactionIdField;
            }
            set {
                if ((this.TransactionIdField.Equals(value) != true)) {
                    this.TransactionIdField = value;
                    this.RaisePropertyChanged("TransactionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TransactionReceiptId {
            get {
                return this.TransactionReceiptIdField;
            }
            set {
                if ((this.TransactionReceiptIdField.Equals(value) != true)) {
                    this.TransactionReceiptIdField = value;
                    this.RaisePropertyChanged("TransactionReceiptId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TransactionSearchCriteriaDTO", Namespace="http://schemas.datacontract.org/2004/07/ExpenseTracker.BusinessObjects")]
    [System.SerializableAttribute()]
    public partial class TransactionSearchCriteriaDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PageNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PageSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ExpenseTrackerWeb.Business.ExpenseTrackerService.SearchPeriod SearchPeriodField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartDateField;
        
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
        public System.DateTime EndDate {
            get {
                return this.EndDateField;
            }
            set {
                if ((this.EndDateField.Equals(value) != true)) {
                    this.EndDateField = value;
                    this.RaisePropertyChanged("EndDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageNumber {
            get {
                return this.PageNumberField;
            }
            set {
                if ((this.PageNumberField.Equals(value) != true)) {
                    this.PageNumberField = value;
                    this.RaisePropertyChanged("PageNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageSize {
            get {
                return this.PageSizeField;
            }
            set {
                if ((this.PageSizeField.Equals(value) != true)) {
                    this.PageSizeField = value;
                    this.RaisePropertyChanged("PageSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ExpenseTrackerWeb.Business.ExpenseTrackerService.SearchPeriod SearchPeriod {
            get {
                return this.SearchPeriodField;
            }
            set {
                if ((this.SearchPeriodField.Equals(value) != true)) {
                    this.SearchPeriodField = value;
                    this.RaisePropertyChanged("SearchPeriod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((this.StartDateField.Equals(value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SearchPeriod", Namespace="http://schemas.datacontract.org/2004/07/ExpenseTracker.BusinessObjects")]
    public enum SearchPeriod : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Weekly = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Monthly = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Yearly = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ExpenseTrackerService.IExpenseTrackerService")]
    public interface IExpenseTrackerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseTrackerService/CreateTransaction", ReplyAction="http://tempuri.org/IExpenseTrackerService/CreateTransactionResponse")]
        void CreateTransaction(ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionDTO transaction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseTrackerService/CreateTransaction", ReplyAction="http://tempuri.org/IExpenseTrackerService/CreateTransactionResponse")]
        System.Threading.Tasks.Task CreateTransactionAsync(ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionDTO transaction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseTrackerService/CreateTransactionCategory", ReplyAction="http://tempuri.org/IExpenseTrackerService/CreateTransactionCategoryResponse")]
        void CreateTransactionCategory(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseTrackerService/CreateTransactionCategory", ReplyAction="http://tempuri.org/IExpenseTrackerService/CreateTransactionCategoryResponse")]
        System.Threading.Tasks.Task CreateTransactionCategoryAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseTrackerService/GetTransactionCategories", ReplyAction="http://tempuri.org/IExpenseTrackerService/GetTransactionCategoriesResponse")]
        ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionCategoryDTO[] GetTransactionCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseTrackerService/GetTransactionCategories", ReplyAction="http://tempuri.org/IExpenseTrackerService/GetTransactionCategoriesResponse")]
        System.Threading.Tasks.Task<ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionCategoryDTO[]> GetTransactionCategoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseTrackerService/CategoryExists", ReplyAction="http://tempuri.org/IExpenseTrackerService/CategoryExistsResponse")]
        bool CategoryExists(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseTrackerService/CategoryExists", ReplyAction="http://tempuri.org/IExpenseTrackerService/CategoryExistsResponse")]
        System.Threading.Tasks.Task<bool> CategoryExistsAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseTrackerService/GetTransactions", ReplyAction="http://tempuri.org/IExpenseTrackerService/GetTransactionsResponse")]
        ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionDTO[] GetTransactions(ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionSearchCriteriaDTO searchCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseTrackerService/GetTransactions", ReplyAction="http://tempuri.org/IExpenseTrackerService/GetTransactionsResponse")]
        System.Threading.Tasks.Task<ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionDTO[]> GetTransactionsAsync(ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionSearchCriteriaDTO searchCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseTrackerService/GetTransactionReceipts", ReplyAction="http://tempuri.org/IExpenseTrackerService/GetTransactionReceiptsResponse")]
        ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionReceiptDTO[] GetTransactionReceipts(int transactionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseTrackerService/GetTransactionReceipts", ReplyAction="http://tempuri.org/IExpenseTrackerService/GetTransactionReceiptsResponse")]
        System.Threading.Tasks.Task<ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionReceiptDTO[]> GetTransactionReceiptsAsync(int transactionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseTrackerService/GetTransaction", ReplyAction="http://tempuri.org/IExpenseTrackerService/GetTransactionResponse")]
        ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionDTO GetTransaction(int transactionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseTrackerService/GetTransaction", ReplyAction="http://tempuri.org/IExpenseTrackerService/GetTransactionResponse")]
        System.Threading.Tasks.Task<ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionDTO> GetTransactionAsync(int transactionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseTrackerService/DeleteTransaction", ReplyAction="http://tempuri.org/IExpenseTrackerService/DeleteTransactionResponse")]
        void DeleteTransaction(int transactionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExpenseTrackerService/DeleteTransaction", ReplyAction="http://tempuri.org/IExpenseTrackerService/DeleteTransactionResponse")]
        System.Threading.Tasks.Task DeleteTransactionAsync(int transactionId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IExpenseTrackerServiceChannel : ExpenseTrackerWeb.Business.ExpenseTrackerService.IExpenseTrackerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExpenseTrackerServiceClient : System.ServiceModel.ClientBase<ExpenseTrackerWeb.Business.ExpenseTrackerService.IExpenseTrackerService>, ExpenseTrackerWeb.Business.ExpenseTrackerService.IExpenseTrackerService {
        
        public ExpenseTrackerServiceClient() {
        }
        
        public ExpenseTrackerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExpenseTrackerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExpenseTrackerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExpenseTrackerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void CreateTransaction(ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionDTO transaction) {
            base.Channel.CreateTransaction(transaction);
        }
        
        public System.Threading.Tasks.Task CreateTransactionAsync(ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionDTO transaction) {
            return base.Channel.CreateTransactionAsync(transaction);
        }
        
        public void CreateTransactionCategory(string name) {
            base.Channel.CreateTransactionCategory(name);
        }
        
        public System.Threading.Tasks.Task CreateTransactionCategoryAsync(string name) {
            return base.Channel.CreateTransactionCategoryAsync(name);
        }
        
        public ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionCategoryDTO[] GetTransactionCategories() {
            return base.Channel.GetTransactionCategories();
        }
        
        public System.Threading.Tasks.Task<ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionCategoryDTO[]> GetTransactionCategoriesAsync() {
            return base.Channel.GetTransactionCategoriesAsync();
        }
        
        public bool CategoryExists(string name) {
            return base.Channel.CategoryExists(name);
        }
        
        public System.Threading.Tasks.Task<bool> CategoryExistsAsync(string name) {
            return base.Channel.CategoryExistsAsync(name);
        }
        
        public ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionDTO[] GetTransactions(ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionSearchCriteriaDTO searchCriteria) {
            return base.Channel.GetTransactions(searchCriteria);
        }
        
        public System.Threading.Tasks.Task<ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionDTO[]> GetTransactionsAsync(ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionSearchCriteriaDTO searchCriteria) {
            return base.Channel.GetTransactionsAsync(searchCriteria);
        }
        
        public ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionReceiptDTO[] GetTransactionReceipts(int transactionId) {
            return base.Channel.GetTransactionReceipts(transactionId);
        }
        
        public System.Threading.Tasks.Task<ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionReceiptDTO[]> GetTransactionReceiptsAsync(int transactionId) {
            return base.Channel.GetTransactionReceiptsAsync(transactionId);
        }
        
        public ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionDTO GetTransaction(int transactionId) {
            return base.Channel.GetTransaction(transactionId);
        }
        
        public System.Threading.Tasks.Task<ExpenseTrackerWeb.Business.ExpenseTrackerService.TransactionDTO> GetTransactionAsync(int transactionId) {
            return base.Channel.GetTransactionAsync(transactionId);
        }
        
        public void DeleteTransaction(int transactionId) {
            base.Channel.DeleteTransaction(transactionId);
        }
        
        public System.Threading.Tasks.Task DeleteTransactionAsync(int transactionId) {
            return base.Channel.DeleteTransactionAsync(transactionId);
        }
    }
}
