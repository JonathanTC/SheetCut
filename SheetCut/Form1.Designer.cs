namespace SheetCut
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addAnimationButton = new System.Windows.Forms.ToolStripButton();
            this.removeAnimationButton = new System.Windows.Forms.ToolStripButton();
            this.renameAnimationButton = new System.Windows.Forms.ToolStripButton();
            this.upAnimationButton = new System.Windows.Forms.ToolStripButton();
            this.downAnimationButton = new System.Windows.Forms.ToolStripButton();
            this.treeAnimation = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.cutSpriteButton = new System.Windows.Forms.ToolStripButton();
            this.removeSpriteButton = new System.Windows.Forms.ToolStripButton();
            this.editSpriteButton = new System.Windows.Forms.ToolStripButton();
            this.exportSpriteButton = new System.Windows.Forms.ToolStripButton();
            this.treeSprite = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timeLine = new System.Windows.Forms.DataGridView();
            this.Frame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sprite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.removeFrameButton = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lecteur = new System.Windows.Forms.PictureBox();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.playPlayerButton = new System.Windows.Forms.ToolStripButton();
            this.stopPlayerButton = new System.Windows.Forms.ToolStripButton();
            this.repeatPlayerButton = new System.Windows.Forms.ToolStripButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.image = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.zoomInImageButton = new System.Windows.Forms.ToolStripButton();
            this.zoomOutImageButton = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.frameTimer = new System.Windows.Forms.Timer(this.components);
            this.saveDialogue = new System.Windows.Forms.SaveFileDialog();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeLine)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecteur)).BeginInit();
            this.toolStrip4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.panel6.SuspendLayout();
            this.toolStrip5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.treeAnimation);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 168);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAnimationButton,
            this.removeAnimationButton,
            this.renameAnimationButton,
            this.upAnimationButton,
            this.downAnimationButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(112, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(24, 164);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // addAnimationButton
            // 
            this.addAnimationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addAnimationButton.Image = ((System.Drawing.Image)(resources.GetObject("addAnimationButton.Image")));
            this.addAnimationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addAnimationButton.Name = "addAnimationButton";
            this.addAnimationButton.Size = new System.Drawing.Size(21, 20);
            this.addAnimationButton.Text = "toolStripButton1";
            this.addAnimationButton.ToolTipText = "Ajouter une animation";
            this.addAnimationButton.Click += new System.EventHandler(this.addAnimationButton_Click);
            // 
            // removeAnimationButton
            // 
            this.removeAnimationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeAnimationButton.Enabled = false;
            this.removeAnimationButton.Image = ((System.Drawing.Image)(resources.GetObject("removeAnimationButton.Image")));
            this.removeAnimationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeAnimationButton.Name = "removeAnimationButton";
            this.removeAnimationButton.Size = new System.Drawing.Size(21, 20);
            this.removeAnimationButton.Text = "toolStripButton2";
            this.removeAnimationButton.ToolTipText = "Supprimer l\'animation";
            this.removeAnimationButton.Click += new System.EventHandler(this.removeAnimationButton_Click);
            // 
            // renameAnimationButton
            // 
            this.renameAnimationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.renameAnimationButton.Enabled = false;
            this.renameAnimationButton.Image = ((System.Drawing.Image)(resources.GetObject("renameAnimationButton.Image")));
            this.renameAnimationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.renameAnimationButton.Name = "renameAnimationButton";
            this.renameAnimationButton.Size = new System.Drawing.Size(21, 20);
            this.renameAnimationButton.Text = "toolStripButton1";
            this.renameAnimationButton.ToolTipText = "Renommer l\'animation";
            this.renameAnimationButton.Click += new System.EventHandler(this.renameAnimationButton_Click);
            // 
            // upAnimationButton
            // 
            this.upAnimationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.upAnimationButton.Enabled = false;
            this.upAnimationButton.Image = ((System.Drawing.Image)(resources.GetObject("upAnimationButton.Image")));
            this.upAnimationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.upAnimationButton.Name = "upAnimationButton";
            this.upAnimationButton.Size = new System.Drawing.Size(21, 20);
            this.upAnimationButton.Text = "toolStripButton1";
            this.upAnimationButton.ToolTipText = "Déplacer vers le haut";
            this.upAnimationButton.Click += new System.EventHandler(this.upAnimationButton_Click);
            // 
            // downAnimationButton
            // 
            this.downAnimationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.downAnimationButton.Enabled = false;
            this.downAnimationButton.Image = ((System.Drawing.Image)(resources.GetObject("downAnimationButton.Image")));
            this.downAnimationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.downAnimationButton.Name = "downAnimationButton";
            this.downAnimationButton.Size = new System.Drawing.Size(21, 20);
            this.downAnimationButton.Text = "toolStripButton1";
            this.downAnimationButton.ToolTipText = "Déplacer vers le bas";
            this.downAnimationButton.Click += new System.EventHandler(this.downAnimationButton_Click);
            // 
            // treeAnimation
            // 
            this.treeAnimation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeAnimation.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeAnimation.FullRowSelect = true;
            this.treeAnimation.HideSelection = false;
            this.treeAnimation.Location = new System.Drawing.Point(0, 0);
            this.treeAnimation.Name = "treeAnimation";
            this.treeAnimation.ShowLines = false;
            this.treeAnimation.ShowPlusMinus = false;
            this.treeAnimation.ShowRootLines = false;
            this.treeAnimation.Size = new System.Drawing.Size(114, 164);
            this.treeAnimation.TabIndex = 0;
            this.treeAnimation.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeAnimation_AfterLabelEdit);
            this.treeAnimation.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeAnimation_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Animations";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.toolStripSeparator1,
            this.enregistrerToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sprites";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Controls.Add(this.treeSprite);
            this.panel2.Location = new System.Drawing.Point(167, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 168);
            this.panel2.TabIndex = 3;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutSpriteButton,
            this.removeSpriteButton,
            this.editSpriteButton,
            this.exportSpriteButton});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(112, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(24, 164);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // cutSpriteButton
            // 
            this.cutSpriteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutSpriteButton.Enabled = false;
            this.cutSpriteButton.Image = ((System.Drawing.Image)(resources.GetObject("cutSpriteButton.Image")));
            this.cutSpriteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutSpriteButton.Name = "cutSpriteButton";
            this.cutSpriteButton.Size = new System.Drawing.Size(21, 20);
            this.cutSpriteButton.Text = "toolStripButton1";
            this.cutSpriteButton.ToolTipText = "Découper une frame";
            this.cutSpriteButton.Click += new System.EventHandler(this.cutSpriteButton_Click);
            // 
            // removeSpriteButton
            // 
            this.removeSpriteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeSpriteButton.Enabled = false;
            this.removeSpriteButton.Image = ((System.Drawing.Image)(resources.GetObject("removeSpriteButton.Image")));
            this.removeSpriteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeSpriteButton.Name = "removeSpriteButton";
            this.removeSpriteButton.Size = new System.Drawing.Size(21, 20);
            this.removeSpriteButton.Text = "toolStripButton2";
            this.removeSpriteButton.ToolTipText = "Supprimer la frame";
            this.removeSpriteButton.Click += new System.EventHandler(this.removeSpriteButton_Click);
            // 
            // editSpriteButton
            // 
            this.editSpriteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editSpriteButton.Enabled = false;
            this.editSpriteButton.Image = ((System.Drawing.Image)(resources.GetObject("editSpriteButton.Image")));
            this.editSpriteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editSpriteButton.Name = "editSpriteButton";
            this.editSpriteButton.Size = new System.Drawing.Size(21, 20);
            this.editSpriteButton.Text = "toolStripButton1";
            this.editSpriteButton.ToolTipText = "Editer les collisions";
            this.editSpriteButton.Click += new System.EventHandler(this.editSpriteButton_Click);
            // 
            // exportSpriteButton
            // 
            this.exportSpriteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportSpriteButton.Enabled = false;
            this.exportSpriteButton.Image = ((System.Drawing.Image)(resources.GetObject("exportSpriteButton.Image")));
            this.exportSpriteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportSpriteButton.Name = "exportSpriteButton";
            this.exportSpriteButton.Size = new System.Drawing.Size(21, 20);
            this.exportSpriteButton.Text = "toolStripButton6";
            this.exportSpriteButton.ToolTipText = "Ajouter à la séquence";
            this.exportSpriteButton.Click += new System.EventHandler(this.exportSpriteButton_Click);
            // 
            // treeSprite
            // 
            this.treeSprite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeSprite.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeSprite.FullRowSelect = true;
            this.treeSprite.HideSelection = false;
            this.treeSprite.Location = new System.Drawing.Point(0, 0);
            this.treeSprite.Name = "treeSprite";
            this.treeSprite.ShowLines = false;
            this.treeSprite.ShowPlusMinus = false;
            this.treeSprite.ShowRootLines = false;
            this.treeSprite.Size = new System.Drawing.Size(114, 164);
            this.treeSprite.TabIndex = 0;
            this.treeSprite.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeSprite_NodeMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Frames";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.timeLine);
            this.panel3.Controls.Add(this.toolStrip3);
            this.panel3.Location = new System.Drawing.Point(322, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 168);
            this.panel3.TabIndex = 5;
            // 
            // timeLine
            // 
            this.timeLine.AllowUserToAddRows = false;
            this.timeLine.AllowUserToDeleteRows = false;
            this.timeLine.AllowUserToResizeColumns = false;
            this.timeLine.AllowUserToResizeRows = false;
            this.timeLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timeLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Frame,
            this.Sprite,
            this.Temps});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.timeLine.DefaultCellStyle = dataGridViewCellStyle2;
            this.timeLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLine.Location = new System.Drawing.Point(0, 0);
            this.timeLine.MultiSelect = false;
            this.timeLine.Name = "timeLine";
            this.timeLine.RowHeadersVisible = false;
            this.timeLine.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.timeLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.timeLine.Size = new System.Drawing.Size(135, 164);
            this.timeLine.TabIndex = 2;
            this.timeLine.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.timeLine_CellEndEdit);
            // 
            // Frame
            // 
            this.Frame.FillWeight = 45.68528F;
            this.Frame.HeaderText = "";
            this.Frame.MaxInputLength = 2;
            this.Frame.Name = "Frame";
            this.Frame.ReadOnly = true;
            this.Frame.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Sprite
            // 
            this.Sprite.FillWeight = 127.1574F;
            this.Sprite.HeaderText = "Sprite";
            this.Sprite.Name = "Sprite";
            this.Sprite.ReadOnly = true;
            this.Sprite.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Temps
            // 
            this.Temps.FillWeight = 127.1574F;
            this.Temps.HeaderText = "Temps";
            this.Temps.Name = "Temps";
            this.Temps.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFrameButton});
            this.toolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip3.Location = new System.Drawing.Point(135, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(24, 164);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            this.toolStrip3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // removeFrameButton
            // 
            this.removeFrameButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeFrameButton.Enabled = false;
            this.removeFrameButton.Image = ((System.Drawing.Image)(resources.GetObject("removeFrameButton.Image")));
            this.removeFrameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeFrameButton.Name = "removeFrameButton";
            this.removeFrameButton.Size = new System.Drawing.Size(21, 20);
            this.removeFrameButton.Text = "toolStripButton1";
            this.removeFrameButton.ToolTipText = "Supprimer la frame";
            this.removeFrameButton.Click += new System.EventHandler(this.removeFrameButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lecteur";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lecteur);
            this.panel4.Controls.Add(this.toolStrip4);
            this.panel4.Location = new System.Drawing.Point(501, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 168);
            this.panel4.TabIndex = 7;
            // 
            // lecteur
            // 
            this.lecteur.BackColor = System.Drawing.Color.Black;
            this.lecteur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lecteur.Location = new System.Drawing.Point(0, 0);
            this.lecteur.Name = "lecteur";
            this.lecteur.Size = new System.Drawing.Size(135, 164);
            this.lecteur.TabIndex = 2;
            this.lecteur.TabStop = false;
            this.lecteur.Paint += new System.Windows.Forms.PaintEventHandler(this.lecteur_Paint);
            // 
            // toolStrip4
            // 
            this.toolStrip4.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playPlayerButton,
            this.stopPlayerButton,
            this.repeatPlayerButton});
            this.toolStrip4.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip4.Location = new System.Drawing.Point(135, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(24, 164);
            this.toolStrip4.TabIndex = 1;
            this.toolStrip4.Text = "toolStrip4";
            this.toolStrip4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // playPlayerButton
            // 
            this.playPlayerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playPlayerButton.Enabled = false;
            this.playPlayerButton.Image = ((System.Drawing.Image)(resources.GetObject("playPlayerButton.Image")));
            this.playPlayerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playPlayerButton.Name = "playPlayerButton";
            this.playPlayerButton.Size = new System.Drawing.Size(21, 20);
            this.playPlayerButton.Text = "toolStripButton8";
            this.playPlayerButton.ToolTipText = "Démarrer";
            this.playPlayerButton.Click += new System.EventHandler(this.playPlayerButton_Click);
            // 
            // stopPlayerButton
            // 
            this.stopPlayerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopPlayerButton.Enabled = false;
            this.stopPlayerButton.Image = ((System.Drawing.Image)(resources.GetObject("stopPlayerButton.Image")));
            this.stopPlayerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopPlayerButton.Name = "stopPlayerButton";
            this.stopPlayerButton.Size = new System.Drawing.Size(21, 20);
            this.stopPlayerButton.Text = "toolStripButton9";
            this.stopPlayerButton.ToolTipText = "Arreter";
            this.stopPlayerButton.Click += new System.EventHandler(this.stopPlayerButton_Click);
            // 
            // repeatPlayerButton
            // 
            this.repeatPlayerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.repeatPlayerButton.Enabled = false;
            this.repeatPlayerButton.Image = ((System.Drawing.Image)(resources.GetObject("repeatPlayerButton.Image")));
            this.repeatPlayerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.repeatPlayerButton.Name = "repeatPlayerButton";
            this.repeatPlayerButton.Size = new System.Drawing.Size(21, 20);
            this.repeatPlayerButton.Text = "toolStripButton1";
            this.repeatPlayerButton.ToolTipText = "Boucler";
            this.repeatPlayerButton.Click += new System.EventHandler(this.repeatPlayerButton_Click);
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.image);
            this.panel5.Location = new System.Drawing.Point(12, 262);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(650, 300);
            this.panel5.TabIndex = 10;
            // 
            // image
            // 
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.Location = new System.Drawing.Point(0, 0);
            this.image.Margin = new System.Windows.Forms.Padding(0);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(1598, 992);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.image.Paint += new System.Windows.Forms.PaintEventHandler(this.image_Paint);
            this.image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.image_MouseDown);
            this.image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.image_MouseMove);
            this.image.MouseUp += new System.Windows.Forms.MouseEventHandler(this.image_MouseUp);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.toolStrip5);
            this.panel6.Location = new System.Drawing.Point(12, 231);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(650, 30);
            this.panel6.TabIndex = 11;
            // 
            // toolStrip5
            // 
            this.toolStrip5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.zoomInImageButton,
            this.zoomOutImageButton});
            this.toolStrip5.Location = new System.Drawing.Point(0, 0);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.Size = new System.Drawing.Size(650, 30);
            this.toolStrip5.TabIndex = 0;
            this.toolStrip5.Text = "toolStrip5";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 27);
            this.toolStripLabel1.Text = "Spritesheet";
            // 
            // zoomInImageButton
            // 
            this.zoomInImageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInImageButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomInImageButton.Image")));
            this.zoomInImageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInImageButton.Name = "zoomInImageButton";
            this.zoomInImageButton.Size = new System.Drawing.Size(23, 27);
            this.zoomInImageButton.Text = "toolStripButton11";
            this.zoomInImageButton.ToolTipText = "Zoomer";
            this.zoomInImageButton.Click += new System.EventHandler(this.zoomInImageButton_Click);
            // 
            // zoomOutImageButton
            // 
            this.zoomOutImageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutImageButton.Enabled = false;
            this.zoomOutImageButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutImageButton.Image")));
            this.zoomOutImageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutImageButton.Name = "zoomOutImageButton";
            this.zoomOutImageButton.Size = new System.Drawing.Size(23, 27);
            this.zoomOutImageButton.Text = "toolStripButton12";
            this.zoomOutImageButton.ToolTipText = "Dezoomer";
            this.zoomOutImageButton.Click += new System.EventHandler(this.zoomOutImageButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frameTimer
            // 
            this.frameTimer.Interval = 10;
            this.frameTimer.Tick += new System.EventHandler(this.frameTimer_Tick);
            // 
            // saveDialogue
            // 
            this.saveDialogue.DefaultExt = "json";
            this.saveDialogue.Filter = "Fichier Json|*.Json";
            this.saveDialogue.Title = "Exporter";
            this.saveDialogue.ValidateNames = false;
            this.saveDialogue.FileOk += new System.ComponentModel.CancelEventHandler(this.saveDialogue_FileOk);
            // 
            // openImage
            // 
            this.openImage.FileName = "openFileDialog1";
            this.openImage.FileOk += new System.ComponentModel.CancelEventHandler(this.openImage_FileOk);
            // 
            // Form1
            // 
            this.AccessibleName = "form1";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 575);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Application";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeLine)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecteur)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addAnimationButton;
        private System.Windows.Forms.TreeView treeAnimation;
        private System.Windows.Forms.ToolStripButton removeAnimationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton cutSpriteButton;
        private System.Windows.Forms.ToolStripButton removeSpriteButton;
        private System.Windows.Forms.TreeView treeSprite;
        private System.Windows.Forms.ToolStripButton exportSpriteButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView timeLine;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton removeFrameButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox lecteur;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton playPlayerButton;
        private System.Windows.Forms.ToolStripButton stopPlayerButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton zoomInImageButton;
        private System.Windows.Forms.ToolStripButton zoomOutImageButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton renameAnimationButton;
        private System.Windows.Forms.ToolStripButton upAnimationButton;
        private System.Windows.Forms.ToolStripButton downAnimationButton;
        private System.Windows.Forms.ToolStripButton editSpriteButton;
        private System.Windows.Forms.ToolStripButton repeatPlayerButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sprite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temps;
        private System.Windows.Forms.Timer frameTimer;
        private System.Windows.Forms.SaveFileDialog saveDialogue;
        private System.Windows.Forms.OpenFileDialog openImage;
    }
}

