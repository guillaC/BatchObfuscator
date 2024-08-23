namespace BatchProtect
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            contextMenu = new ContextMenuStrip(components);
            TSMIRemoveCommentary = new ToolStripMenuItem();
            TSMIRandomVarSub = new ToolStripMenuItem();
            TSMISubstringEncode = new ToolStripMenuItem();
            TSMIFlowObf = new ToolStripMenuItem();
            TSMIEncapsulateInTempFiles = new ToolStripMenuItem();
            FCTBBatchCode = new FastColoredTextBoxNS.FastColoredTextBox();
            contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FCTBBatchCode).BeginInit();
            SuspendLayout();
            // 
            // contextMenu
            // 
            contextMenu.Items.AddRange(new ToolStripItem[] { TSMIRemoveCommentary, TSMIRandomVarSub, TSMISubstringEncode, TSMIEncapsulateInTempFiles, TSMIFlowObf });
            contextMenu.Name = "contextMenuStrip1";
            contextMenu.ShowImageMargin = false;
            contextMenu.Size = new Size(274, 136);
            // 
            // TSMIRemoveCommentary
            // 
            TSMIRemoveCommentary.Name = "TSMIRemoveCommentary";
            TSMIRemoveCommentary.Size = new Size(273, 22);
            TSMIRemoveCommentary.Text = "Remove comments";
            TSMIRemoveCommentary.Click += TSMIRemoveCommentary_Click;
            // 
            // TSMIRandomVarSub
            // 
            TSMIRandomVarSub.Name = "TSMIRandomVarSub";
            TSMIRandomVarSub.Size = new Size(273, 22);
            TSMIRandomVarSub.Text = "Randomize variable and subroutine names";
            TSMIRandomVarSub.Click += TSMIRandomVar_Click;
            // 
            // TSMISubstringEncode
            // 
            TSMISubstringEncode.Name = "TSMISubstringEncode";
            TSMISubstringEncode.Size = new Size(273, 22);
            TSMISubstringEncode.Text = "Encode substrings by custom variables";
            TSMISubstringEncode.Click += TSMISubstringEncode_Click;
            // 
            // TSMIFlowObf
            // 
            TSMIFlowObf.Name = "TSMIFlowObf";
            TSMIFlowObf.Size = new Size(273, 22);
            TSMIFlowObf.Text = "Obfuscate flow";
            TSMIFlowObf.Click += TSMIFlowObf_Click;
            // 
            // TSMIEncapsulateInTempFiles
            // 
            TSMIEncapsulateInTempFiles.Name = "TSMIEncapsulateInTempFiles";
            TSMIEncapsulateInTempFiles.Size = new Size(273, 22);
            TSMIEncapsulateInTempFiles.Text = "Encapsulate In Temp File";
            TSMIEncapsulateInTempFiles.Click += TSMIEncapsulateInTempFile_Click;
            // 
            // FCTBBatchCode
            // 
            this.FCTBBatchCode.AllowMacroRecording = false;
            this.FCTBBatchCode.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.FCTBBatchCode.AutoIndentCharsPatterns = "\r\n^\\s*\\$[\\w\\.\\[\\]\\\'\\\"]+\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.FCTBBatchCode.AutoScrollMinSize = new System.Drawing.Size(227, 14);
            this.FCTBBatchCode.BackBrush = null;
            this.FCTBBatchCode.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.FCTBBatchCode.CharHeight = 14;
            this.FCTBBatchCode.CharWidth = 8;
            this.FCTBBatchCode.ContextMenuStrip = this.contextMenu;
            this.FCTBBatchCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FCTBBatchCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.FCTBBatchCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FCTBBatchCode.IsReplaceMode = false;
            this.FCTBBatchCode.LeftBracket = '(';
            this.FCTBBatchCode.LeftBracket2 = '{';
            this.FCTBBatchCode.Location = new System.Drawing.Point(0, 0);
            this.FCTBBatchCode.Name = "FCTBBatchCode";
            this.FCTBBatchCode.Paddings = new System.Windows.Forms.Padding(0);
            this.FCTBBatchCode.RightBracket = ')';
            this.FCTBBatchCode.RightBracket2 = '}';
            this.FCTBBatchCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.FCTBBatchCode.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("FCTBBatchCode.ServiceColors")));
            this.FCTBBatchCode.Size = new System.Drawing.Size(637, 369);
            this.FCTBBatchCode.TabIndex = 1;
            this.FCTBBatchCode.Text = "REM Batch Code Obfuscator github.com/guillaC";
            this.FCTBBatchCode.Zoom = 100;
            this.FCTBBatchCode.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.FCTBBatchCode_TextChanged);
            this.FCTBBatchCode.Pasting += new System.EventHandler<FastColoredTextBoxNS.TextChangingEventArgs>(this.FCTBBatchCode_Pasting);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 369);
            Controls.Add(FCTBBatchCode);
            Name = "Form1";
            Text = "Batch Code Obfuscator";
            contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FCTBBatchCode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenu;
        private FastColoredTextBoxNS.FastColoredTextBox FCTBBatchCode;
        private ToolStripMenuItem TSMIRemoveCommentary;
        private ToolStripMenuItem TSMIRandomVarSub;
        private ToolStripMenuItem TSMISubstringEncode;
        private ToolStripMenuItem TSMIFlowObf;
        private ToolStripMenuItem TSMIEncapsulateInTempFiles;
    }
}
