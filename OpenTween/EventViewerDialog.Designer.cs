﻿namespace OpenTween
{
    partial class EventViewerDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventViewerDialog));
            this.SaveLogButton = new System.Windows.Forms.Button();
            this.CheckBoxFilter = new System.Windows.Forms.CheckBox();
            this.TabPageAll = new System.Windows.Forms.TabPage();
            this.EventList = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CheckRegex = new System.Windows.Forms.CheckBox();
            this.TextBoxKeyword = new System.Windows.Forms.TextBox();
            this.StatusLabelCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TabEventType = new System.Windows.Forms.TabControl();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.CheckExcludeMyEvent = new System.Windows.Forms.CheckBox();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TabPageAll.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.TabEventType.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveLogButton
            // 
            resources.ApplyResources(this.SaveLogButton, "SaveLogButton");
            this.SaveLogButton.Name = "SaveLogButton";
            this.SaveLogButton.UseVisualStyleBackColor = true;
            this.SaveLogButton.Click += new System.EventHandler(this.SaveLogButton_Click);
            // 
            // CheckBoxFilter
            // 
            resources.ApplyResources(this.CheckBoxFilter, "CheckBoxFilter");
            this.CheckBoxFilter.Name = "CheckBoxFilter";
            this.CheckBoxFilter.UseVisualStyleBackColor = true;
            this.CheckBoxFilter.CheckedChanged += new System.EventHandler(this.TabEventType_SelectedIndexChanged);
            // 
            // TabPageAll
            // 
            this.TabPageAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.TabPageAll.Controls.Add(this.EventList);
            resources.ApplyResources(this.TabPageAll, "TabPageAll");
            this.TabPageAll.Name = "TabPageAll";
            this.TabPageAll.Tag = "All";
            this.TabPageAll.UseVisualStyleBackColor = true;
            // 
            // EventList
            // 
            this.EventList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4});
            resources.ApplyResources(this.EventList, "EventList");
            this.EventList.FullRowSelect = true;
            this.EventList.Name = "EventList";
            this.EventList.ShowItemToolTips = true;
            this.EventList.UseCompatibleStateImageBehavior = false;
            this.EventList.View = System.Windows.Forms.View.Details;
            this.EventList.VirtualMode = true;
            this.EventList.CacheVirtualItems += new System.Windows.Forms.CacheVirtualItemsEventHandler(this.EventList_CacheVirtualItems);
            this.EventList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.EventList_RetrieveVirtualItem);
            this.EventList.DoubleClick += new System.EventHandler(this.EventList_DoubleClick);
            this.EventList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EventList_KeyDown);
            // 
            // ColumnHeader1
            // 
            resources.ApplyResources(this.ColumnHeader1, "ColumnHeader1");
            // 
            // ColumnHeader2
            // 
            resources.ApplyResources(this.ColumnHeader2, "ColumnHeader2");
            // 
            // ColumnHeader3
            // 
            resources.ApplyResources(this.ColumnHeader3, "ColumnHeader3");
            // 
            // ColumnHeader4
            // 
            resources.ApplyResources(this.ColumnHeader4, "ColumnHeader4");
            // 
            // CheckRegex
            // 
            resources.ApplyResources(this.CheckRegex, "CheckRegex");
            this.CheckRegex.Name = "CheckRegex";
            this.CheckRegex.UseVisualStyleBackColor = true;
            // 
            // TextBoxKeyword
            // 
            resources.ApplyResources(this.TextBoxKeyword, "TextBoxKeyword");
            this.TextBoxKeyword.Name = "TextBoxKeyword";
            this.TextBoxKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyword_KeyPress);
            // 
            // StatusLabelCount
            // 
            this.StatusLabelCount.Name = "StatusLabelCount";
            resources.ApplyResources(this.StatusLabelCount, "StatusLabelCount");
            // 
            // OK_Button
            // 
            resources.ApplyResources(this.OK_Button, "OK_Button");
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabelCount});
            resources.ApplyResources(this.StatusStrip1, "StatusStrip1");
            this.StatusStrip1.Name = "StatusStrip1";
            // 
            // TabEventType
            // 
            resources.ApplyResources(this.TabEventType, "TabEventType");
            this.TabEventType.Controls.Add(this.TabPageAll);
            this.TabEventType.Name = "TabEventType";
            this.TabEventType.SelectedIndex = 0;
            this.TabEventType.SelectedIndexChanged += new System.EventHandler(this.TabEventType_SelectedIndexChanged);
            this.TabEventType.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabEventType_Selecting);
            // 
            // ButtonRefresh
            // 
            resources.ApplyResources(this.ButtonRefresh, "ButtonRefresh");
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // CheckExcludeMyEvent
            // 
            resources.ApplyResources(this.CheckExcludeMyEvent, "CheckExcludeMyEvent");
            this.CheckExcludeMyEvent.Name = "CheckExcludeMyEvent";
            this.CheckExcludeMyEvent.UseVisualStyleBackColor = true;
            this.CheckExcludeMyEvent.CheckedChanged += new System.EventHandler(this.CheckExcludeMyEvent_CheckedChanged);
            // 
            // EventViewerDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.OK_Button;
            this.Controls.Add(this.SaveLogButton);
            this.Controls.Add(this.CheckBoxFilter);
            this.Controls.Add(this.CheckRegex);
            this.Controls.Add(this.TextBoxKeyword);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.TabEventType);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.CheckExcludeMyEvent);
            this.DoubleBuffered = true;
            this.Name = "EventViewerDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Shown += new System.EventHandler(this.EventViewerDialog_Shown);
            this.TabPageAll.ResumeLayout(false);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.TabEventType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button SaveLogButton;
        internal System.Windows.Forms.CheckBox CheckBoxFilter;
        internal System.Windows.Forms.TabPage TabPageAll;
        internal System.Windows.Forms.ListView EventList;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.CheckBox CheckRegex;
        internal System.Windows.Forms.TextBox TextBoxKeyword;
        internal System.Windows.Forms.ToolStripStatusLabel StatusLabelCount;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.TabControl TabEventType;
        internal System.Windows.Forms.Button ButtonRefresh;
        internal System.Windows.Forms.CheckBox CheckExcludeMyEvent;
        internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
    }
}