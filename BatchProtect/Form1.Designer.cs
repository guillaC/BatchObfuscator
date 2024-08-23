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
            FCTBBatchCode.AllowMacroRecording = false;
            FCTBBatchCode.AutoCompleteBracketsList = new char[]
    {
    '(',
    ')',
    '{',
    '}',
    '[',
    ']',
    '"',
    '"',
    '\'',
    '\''
    };
            FCTBBatchCode.AutoIndentCharsPatterns = "\r\n^\\s*\\$[\\w\\.\\[\\]\\'\\\"]+\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            FCTBBatchCode.AutoScrollMinSize = new Size(227, 14);
            FCTBBatchCode.BackBrush = null;
            FCTBBatchCode.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            FCTBBatchCode.CharHeight = 14;
            FCTBBatchCode.CharWidth = 8;
            FCTBBatchCode.ContextMenuStrip = contextMenu;
            FCTBBatchCode.Cursor = Cursors.IBeam;
            FCTBBatchCode.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            FCTBBatchCode.Dock = DockStyle.Fill;
            FCTBBatchCode.IsReplaceMode = false;
            FCTBBatchCode.LeftBracket = '(';
            FCTBBatchCode.LeftBracket2 = '{';
            FCTBBatchCode.Location = new Point(0, 0);
            FCTBBatchCode.Name = "FCTBBatchCode";
            FCTBBatchCode.Paddings = new Padding(0);
            FCTBBatchCode.RightBracket = ')';
            FCTBBatchCode.RightBracket2 = '}';
            FCTBBatchCode.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            FCTBBatchCode.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("FCTBBatchCode.ServiceColors");
            FCTBBatchCode.Size = new Size(637, 369);
            FCTBBatchCode.TabIndex = 1;
            FCTBBatchCode.Text = "REM Batch Code Obfuscator";
            FCTBBatchCode.Zoom = 100;
            FCTBBatchCode.TextChanged += FCTBBatchCode_TextChanged;
            FCTBBatchCode.Pasting += FCTBBatchCode_Pasting;
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