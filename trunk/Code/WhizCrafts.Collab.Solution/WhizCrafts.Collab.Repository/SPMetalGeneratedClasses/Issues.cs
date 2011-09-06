//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5420
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace WhizCrafts.Collab.Repository
{

    public partial class IssuesDataContext : Microsoft.SharePoint.Linq.DataContext
    {

        #region Extensibility Method Definitions
        partial void OnCreated();
        #endregion

        public IssuesDataContext(string requestUrl) :
            base(requestUrl)
        {
            this.OnCreated();
        }

        /// <summary>
        /// List to track Project Level Issues
        /// </summary>
        [Microsoft.SharePoint.Linq.ListAttribute(Name = "Issues")]
        public Microsoft.SharePoint.Linq.EntityList<Issues> Issues
        {
            get
            {
                return this.GetList<Issues>("Issues");
            }
        }
    }

    /// <summary>
    /// Create a new list item.
    /// </summary>
    [Microsoft.SharePoint.Linq.ContentTypeAttribute(Name = "Item", Id = "0x01")]
    [Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type = typeof(Issue))]
    public partial class Item : Microsoft.SharePoint.Linq.ITrackEntityState, Microsoft.SharePoint.Linq.ITrackOriginalValues, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging
    {

        private System.Nullable<int> _id;

        private System.Nullable<int> _version;

        private string _path;

        private Microsoft.SharePoint.Linq.EntityState _entityState;

        private System.Collections.Generic.IDictionary<string, object> _originalValues;

        private string _title;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate();
        partial void OnCreated();
        #endregion

        Microsoft.SharePoint.Linq.EntityState Microsoft.SharePoint.Linq.ITrackEntityState.EntityState
        {
            get
            {
                return this._entityState;
            }
            set
            {
                if ((value != this._entityState))
                {
                    this._entityState = value;
                }
            }
        }

        System.Collections.Generic.IDictionary<string, object> Microsoft.SharePoint.Linq.ITrackOriginalValues.OriginalValues
        {
            get
            {
                if ((null == this._originalValues))
                {
                    this._originalValues = new System.Collections.Generic.Dictionary<string, object>();
                }
                return this._originalValues;
            }
        }

        public Item()
        {
            this.OnCreated();
        }

        [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "ID", Storage = "_id", ReadOnly = true, FieldType = "Counter")]
        public System.Nullable<int> Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((value != this._id))
                {
                    this.OnPropertyChanging("Id", this._id);
                    this._id = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "owshiddenversion", Storage = "_version", ReadOnly = true, FieldType = "Integer")]
        public System.Nullable<int> Version
        {
            get
            {
                return this._version;
            }
            set
            {
                if ((value != this._version))
                {
                    this.OnPropertyChanging("Version", this._version);
                    this._version = value;
                    this.OnPropertyChanged("Version");
                }
            }
        }

        [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "FileDirRef", Storage = "_path", ReadOnly = true, FieldType = "Lookup", IsLookupValue = true)]
        public string Path
        {
            get
            {
                return this._path;
            }
            set
            {
                if ((value != this._path))
                {
                    this.OnPropertyChanging("Path", this._path);
                    this._path = value;
                    this.OnPropertyChanged("Path");
                }
            }
        }

        [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "Title", Storage = "_title", Required = true, FieldType = "Text")]
        public virtual string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                if ((value != this._title))
                {
                    this.OnPropertyChanging("Title", this._title);
                    this._title = value;
                    this.OnPropertyChanged("Title");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if ((null != this.PropertyChanged))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        protected virtual void OnPropertyChanging(string propertyName, object value)
        {
            if ((null == this._originalValues))
            {
                this._originalValues = new System.Collections.Generic.Dictionary<string, object>();
            }
            if ((false == this._originalValues.ContainsKey(propertyName)))
            {
                this._originalValues.Add(propertyName, value);
            }
            if ((null != this.PropertyChanging))
            {
                this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
            }
        }
    }

    /// <summary>
    /// Track an issue or problem.
    /// </summary>
    [Microsoft.SharePoint.Linq.ContentTypeAttribute(Name = "Issue", Id = "0x0103")]
    [Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type = typeof(Issues))]
    public partial class Issue : Item
    {

        private string _description;

        private string _appendOnlyComments;

        protected System.Nullable<System.DateTime> _dueDate;

        private string _issueID;

        protected System.Nullable<IssueStatus> _issueStatus;

        private System.Nullable<Priority> _priority;

        private System.Nullable<Category> _category;

        private System.Nullable<int> _assignedToId;

        private string _assignedTo;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate();
        partial void OnCreated();
        #endregion

        public Issue()
        {
            this.OnCreated();
        }

        [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "Comment", Storage = "_description", FieldType = "Note")]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                if ((value != this._description))
                {
                    this.OnPropertyChanging("Description", this._description);
                    this._description = value;
                    this.OnPropertyChanged("Description");
                }
            }
        }

        [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "V3Comments", Storage = "_appendOnlyComments", FieldType = "Note")]
        public string AppendOnlyComments
        {
            get
            {
                return this._appendOnlyComments;
            }
            set
            {
                if ((value != this._appendOnlyComments))
                {
                    this.OnPropertyChanging("AppendOnlyComments", this._appendOnlyComments);
                    this._appendOnlyComments = value;
                    this.OnPropertyChanged("AppendOnlyComments");
                }
            }
        }

        [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "TaskDueDate", Storage = "_dueDate", FieldType = "DateTime")]
        public virtual System.Nullable<System.DateTime> DueDate
        {
            get
            {
                return this._dueDate;
            }
            set
            {
                if ((value != this._dueDate))
                {
                    this.OnPropertyChanging("DueDate", this._dueDate);
                    this._dueDate = value;
                    this.OnPropertyChanged("DueDate");
                }
            }
        }

        [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "LinkIssueIDNoMenu", Storage = "_issueID", ReadOnly = true, FieldType = "Computed")]
        public string IssueID
        {
            get
            {
                return this._issueID;
            }
            set
            {
                if ((value != this._issueID))
                {
                    this.OnPropertyChanging("IssueID", this._issueID);
                    this._issueID = value;
                    this.OnPropertyChanged("IssueID");
                }
            }
        }

        [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "IssueStatus", Storage = "_issueStatus", FieldType = "Choice")]
        public virtual System.Nullable<IssueStatus> IssueStatus
        {
            get
            {
                return this._issueStatus;
            }
            set
            {
                if ((value != this._issueStatus))
                {
                    this.OnPropertyChanging("IssueStatus", this._issueStatus);
                    this._issueStatus = value;
                    this.OnPropertyChanged("IssueStatus");
                }
            }
        }

        [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "Priority", Storage = "_priority", FieldType = "Choice")]
        public System.Nullable<Priority> Priority
        {
            get
            {
                return this._priority;
            }
            set
            {
                if ((value != this._priority))
                {
                    this.OnPropertyChanging("Priority", this._priority);
                    this._priority = value;
                    this.OnPropertyChanged("Priority");
                }
            }
        }

        [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "Category", Storage = "_category", FieldType = "Choice")]
        public System.Nullable<Category> Category
        {
            get
            {
                return this._category;
            }
            set
            {
                if ((value != this._category))
                {
                    this.OnPropertyChanging("Category", this._category);
                    this._category = value;
                    this.OnPropertyChanged("Category");
                }
            }
        }

        [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "AssignedTo", Storage = "_assignedToId", FieldType = "User", IsLookupId = true)]
        public System.Nullable<int> AssignedToId
        {
            get
            {
                return this._assignedToId;
            }
            set
            {
                if ((value != this._assignedToId))
                {
                    this.OnPropertyChanging("AssignedToId", this._assignedToId);
                    this._assignedToId = value;
                    this.OnPropertyChanged("AssignedToId");
                }
            }
        }

        [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "AssignedTo", Storage = "_assignedTo", ReadOnly = true, FieldType = "User", IsLookupValue = true)]
        public string AssignedTo
        {
            get
            {
                return this._assignedTo;
            }
            set
            {
                if ((value != this._assignedTo))
                {
                    this.OnPropertyChanging("AssignedTo", this._assignedTo);
                    this._assignedTo = value;
                    this.OnPropertyChanged("AssignedTo");
                }
            }
        }
    }

    /// <summary>
    /// Track an issue or problem.
    /// </summary>
    [Microsoft.SharePoint.Linq.ContentTypeAttribute(Name = "Issue", Id = "0x0103", List = "Issues")]
    public partial class Issues : Issue
    {

        private Microsoft.SharePoint.Linq.EntitySet<Issues> _issues0;

        private Microsoft.SharePoint.Linq.EntitySet<Issues> _relatedIssues;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate();
        partial void OnCreated();
        #endregion

        public Issues()
        {
            this._issues0 = new Microsoft.SharePoint.Linq.EntitySet<Issues>();
            this._issues0.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Issues>>(this.OnIssues0Sync);
            this._issues0.OnChanged += new System.EventHandler(this.OnIssues0Changed);
            this._issues0.OnChanging += new System.EventHandler(this.OnIssues0Changing);
            this._relatedIssues = new Microsoft.SharePoint.Linq.EntitySet<Issues>();
            this._relatedIssues.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Issues>>(this.OnRelatedIssuesSync);
            this._relatedIssues.OnChanged += new System.EventHandler(this.OnRelatedIssuesChanged);
            this._relatedIssues.OnChanging += new System.EventHandler(this.OnRelatedIssuesChanging);
            this.OnCreated();
        }

        [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "DueDate", Storage = "_dueDate", FieldType = "DateTime")]
        public override System.Nullable<System.DateTime> DueDate
        {
            get
            {
                return this._dueDate;
            }
            set
            {
                if ((value != this._dueDate))
                {
                    this.OnPropertyChanging("DueDate", this._dueDate);
                    this._dueDate = value;
                    this.OnPropertyChanged("DueDate");
                }
            }
        }

        [Microsoft.SharePoint.Linq.ColumnAttribute(Name = "Status", Storage = "_issueStatus", FieldType = "Choice")]
        public override System.Nullable<IssueStatus> IssueStatus
        {
            get
            {
                return this._issueStatus;
            }
            set
            {
                if ((value != this._issueStatus))
                {
                    this.OnPropertyChanging("IssueStatus", this._issueStatus);
                    this._issueStatus = value;
                    this.OnPropertyChanged("IssueStatus");
                }
            }
        }

        [Microsoft.SharePoint.Linq.AssociationAttribute(Name = "RelatedIssues", Storage = "_issues0", ReadOnly = true, MultivalueType = Microsoft.SharePoint.Linq.AssociationType.Backward, List = "Issues")]
        public Microsoft.SharePoint.Linq.EntitySet<Issues> Issues0
        {
            get
            {
                return this._issues0;
            }
            set
            {
                this._issues0.Assign(value);
            }
        }

        [Microsoft.SharePoint.Linq.AssociationAttribute(Name = "RelatedIssues", Storage = "_relatedIssues", MultivalueType = Microsoft.SharePoint.Linq.AssociationType.Multi, List = "Issues")]
        public Microsoft.SharePoint.Linq.EntitySet<Issues> RelatedIssues
        {
            get
            {
                return this._relatedIssues;
            }
            set
            {
                this._relatedIssues.Assign(value);
            }
        }

        private void OnIssues0Changing(object sender, System.EventArgs e)
        {
            this.OnPropertyChanging("Issues0", this._issues0.Clone());
        }

        private void OnIssues0Changed(object sender, System.EventArgs e)
        {
            this.OnPropertyChanged("Issues0");
        }

        private void OnIssues0Sync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Issues> e)
        {
            if ((Microsoft.SharePoint.Linq.AssociationChangedState.Added == e.State))
            {
                e.Item.RelatedIssues.Add(this);
            }
            else
            {
                e.Item.RelatedIssues.Remove(this);
            }
        }

        private void OnRelatedIssuesChanging(object sender, System.EventArgs e)
        {
            this.OnPropertyChanging("RelatedIssues", this._relatedIssues.Clone());
        }

        private void OnRelatedIssuesChanged(object sender, System.EventArgs e)
        {
            this.OnPropertyChanged("RelatedIssues");
        }

        private void OnRelatedIssuesSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Issues> e)
        {
            if ((Microsoft.SharePoint.Linq.AssociationChangedState.Added == e.State))
            {
                e.Item.Issues0.Add(this);
            }
            else
            {
                e.Item.Issues0.Remove(this);
            }
        }
    }

    public enum IssueStatus : int
    {

        None = 0,

        Invalid = 1,

        [Microsoft.SharePoint.Linq.ChoiceAttribute(Value = "Active")]
        Active = 2,

        [Microsoft.SharePoint.Linq.ChoiceAttribute(Value = "Resolved")]
        Resolved = 4,

        [Microsoft.SharePoint.Linq.ChoiceAttribute(Value = "Closed")]
        Closed = 8,
    }

    public enum Priority : int
    {

        None = 0,

        Invalid = 1,

        [Microsoft.SharePoint.Linq.ChoiceAttribute(Value = "(1) High")]
        _1High = 2,

        [Microsoft.SharePoint.Linq.ChoiceAttribute(Value = "(2) Normal")]
        _2Normal = 4,

        [Microsoft.SharePoint.Linq.ChoiceAttribute(Value = "(3) Low")]
        _3Low = 8,
    }

    public enum Category : int
    {

        None = 0,

        Invalid = 1,

        [Microsoft.SharePoint.Linq.ChoiceAttribute(Value = "(1) Category1")]
        _1Category1 = 2,

        [Microsoft.SharePoint.Linq.ChoiceAttribute(Value = "(2) Category2")]
        _2Category2 = 4,

        [Microsoft.SharePoint.Linq.ChoiceAttribute(Value = "(3) Category3")]
        _3Category3 = 8,
    }

}
