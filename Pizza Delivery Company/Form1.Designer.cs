namespace Pizza_Delivery_Company
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbx_address = new System.Windows.Forms.TextBox();
            this.tbx_phone = new System.Windows.Forms.TextBox();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_pizza = new System.Windows.Forms.TabPage();
            this.gbx_size = new System.Windows.Forms.GroupBox();
            this.rb_largePizza = new System.Windows.Forms.RadioButton();
            this.rb_mediumPizza = new System.Windows.Forms.RadioButton();
            this.rb_smallPizza = new System.Windows.Forms.RadioButton();
            this.gbx_toppings = new System.Windows.Forms.GroupBox();
            this.cb_pineapple = new System.Windows.Forms.CheckBox();
            this.cb_onions = new System.Windows.Forms.CheckBox();
            this.cb_zucchini = new System.Windows.Forms.CheckBox();
            this.cb_tomatoes = new System.Windows.Forms.CheckBox();
            this.cb_olives = new System.Windows.Forms.CheckBox();
            this.cb_mushrooms = new System.Windows.Forms.CheckBox();
            this.cb_sausage = new System.Windows.Forms.CheckBox();
            this.cb_bacon = new System.Windows.Forms.CheckBox();
            this.cb_ham = new System.Windows.Forms.CheckBox();
            this.cb_chicken = new System.Windows.Forms.CheckBox();
            this.cb_pepperoni = new System.Windows.Forms.CheckBox();
            this.cb_cheese = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbx_sauce = new System.Windows.Forms.ListBox();
            this.lbl_toppings = new System.Windows.Forms.Label();
            this.lbl_sauce = new System.Windows.Forms.Label();
            this.lbl_pizza_instrction = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.tab_sides = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_wingQuant = new System.Windows.Forms.TextBox();
            this.tb_breadstickQuant = new System.Windows.Forms.TextBox();
            this.gbx_sauce = new System.Windows.Forms.GroupBox();
            this.rb_bbq = new System.Windows.Forms.RadioButton();
            this.rb_hot = new System.Windows.Forms.RadioButton();
            this.rb_medium = new System.Windows.Forms.RadioButton();
            this.rb_mild = new System.Windows.Forms.RadioButton();
            this.lbl_wing_quant = new System.Windows.Forms.Label();
            this.lbl_breadsticks = new System.Windows.Forms.Label();
            this.tab_drinks = new System.Windows.Forms.TabPage();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbx_crust = new System.Windows.Forms.GroupBox();
            this.rb_original = new System.Windows.Forms.RadioButton();
            this.rb_supreme = new System.Windows.Forms.RadioButton();
            this.rb_veggie = new System.Windows.Forms.RadioButton();
            this.gbx_drinks = new System.Windows.Forms.GroupBox();
            this.rb_soda = new System.Windows.Forms.RadioButton();
            this.rb_tea = new System.Windows.Forms.RadioButton();
            this.rb_water = new System.Windows.Forms.RadioButton();
            this.rb_none = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tab_pizza.SuspendLayout();
            this.gbx_size.SuspendLayout();
            this.gbx_toppings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab_sides.SuspendLayout();
            this.gbx_sauce.SuspendLayout();
            this.tab_drinks.SuspendLayout();
            this.gbx_crust.SuspendLayout();
            this.gbx_drinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_address
            // 
            this.tbx_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_address.Location = new System.Drawing.Point(23, 1048);
            this.tbx_address.Name = "tbx_address";
            this.tbx_address.Size = new System.Drawing.Size(430, 49);
            this.tbx_address.TabIndex = 0;
            this.tbx_address.TextChanged += new System.EventHandler(this.tbx_address_TextChanged);
            // 
            // tbx_phone
            // 
            this.tbx_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_phone.Location = new System.Drawing.Point(23, 1248);
            this.tbx_phone.Name = "tbx_phone";
            this.tbx_phone.Size = new System.Drawing.Size(430, 49);
            this.tbx_phone.TabIndex = 1;
            this.tbx_phone.TextChanged += new System.EventHandler(this.tbx_phone_TextChanged);
            // 
            // tbx_email
            // 
            this.tbx_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_email.Location = new System.Drawing.Point(23, 1141);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(430, 49);
            this.tbx_email.TabIndex = 2;
            this.tbx_email.TextChanged += new System.EventHandler(this.tbx_email_TextChanged);
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(18, 1020);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(91, 25);
            this.lbl_address.TabIndex = 3;
            this.lbl_address.Text = "Address";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(18, 1207);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(155, 25);
            this.lbl_phone.TabIndex = 4;
            this.lbl_phone.Text = "Phone Number";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(18, 1110);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(72, 25);
            this.lbl_email.TabIndex = 5;
            this.lbl_email.Text = "E-mail";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 926);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(68, 25);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Name";
            // 
            // tbx_name
            // 
            this.tbx_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_name.Location = new System.Drawing.Point(17, 959);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(436, 49);
            this.tbx_name.TabIndex = 7;
            this.tbx_name.TextChanged += new System.EventHandler(this.tbx_name_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_pizza);
            this.tabControl1.Controls.Add(this.tab_sides);
            this.tabControl1.Controls.Add(this.tab_drinks);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1260, 921);
            this.tabControl1.TabIndex = 8;
            // 
            // tab_pizza
            // 
            this.tab_pizza.BackColor = System.Drawing.Color.LightCoral;
            this.tab_pizza.Controls.Add(this.gbx_crust);
            this.tab_pizza.Controls.Add(this.gbx_size);
            this.tab_pizza.Controls.Add(this.gbx_toppings);
            this.tab_pizza.Controls.Add(this.pictureBox1);
            this.tab_pizza.Controls.Add(this.lbx_sauce);
            this.tab_pizza.Controls.Add(this.lbl_toppings);
            this.tab_pizza.Controls.Add(this.lbl_sauce);
            this.tab_pizza.Controls.Add(this.lbl_pizza_instrction);
            this.tab_pizza.Controls.Add(this.lbl_title);
            this.tab_pizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_pizza.Location = new System.Drawing.Point(8, 39);
            this.tab_pizza.Name = "tab_pizza";
            this.tab_pizza.Padding = new System.Windows.Forms.Padding(3);
            this.tab_pizza.Size = new System.Drawing.Size(1244, 874);
            this.tab_pizza.TabIndex = 0;
            this.tab_pizza.Text = "Pizza";
            // 
            // gbx_size
            // 
            this.gbx_size.Controls.Add(this.rb_largePizza);
            this.gbx_size.Controls.Add(this.rb_mediumPizza);
            this.gbx_size.Controls.Add(this.rb_smallPizza);
            this.gbx_size.Location = new System.Drawing.Point(12, 190);
            this.gbx_size.Name = "gbx_size";
            this.gbx_size.Size = new System.Drawing.Size(466, 233);
            this.gbx_size.TabIndex = 17;
            this.gbx_size.TabStop = false;
            this.gbx_size.Text = "Size";
            // 
            // rb_largePizza
            // 
            this.rb_largePizza.AutoSize = true;
            this.rb_largePizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_largePizza.Location = new System.Drawing.Point(36, 172);
            this.rb_largePizza.Name = "rb_largePizza";
            this.rb_largePizza.Size = new System.Drawing.Size(340, 41);
            this.rb_largePizza.TabIndex = 2;
            this.rb_largePizza.TabStop = true;
            this.rb_largePizza.Text = "Large (16\") + $14.99";
            this.rb_largePizza.UseVisualStyleBackColor = true;
            this.rb_largePizza.CheckedChanged += new System.EventHandler(this.rb_largePizza_CheckedChanged);
            // 
            // rb_mediumPizza
            // 
            this.rb_mediumPizza.AutoSize = true;
            this.rb_mediumPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_mediumPizza.Location = new System.Drawing.Point(36, 117);
            this.rb_mediumPizza.Name = "rb_mediumPizza";
            this.rb_mediumPizza.Size = new System.Drawing.Size(371, 41);
            this.rb_mediumPizza.TabIndex = 1;
            this.rb_mediumPizza.TabStop = true;
            this.rb_mediumPizza.Text = "Medium (12\") + $12.99";
            this.rb_mediumPizza.UseVisualStyleBackColor = true;
            this.rb_mediumPizza.CheckedChanged += new System.EventHandler(this.rb_mediumPizza_CheckedChanged);
            // 
            // rb_smallPizza
            // 
            this.rb_smallPizza.AutoSize = true;
            this.rb_smallPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_smallPizza.Location = new System.Drawing.Point(36, 55);
            this.rb_smallPizza.Name = "rb_smallPizza";
            this.rb_smallPizza.Size = new System.Drawing.Size(297, 41);
            this.rb_smallPizza.TabIndex = 0;
            this.rb_smallPizza.TabStop = true;
            this.rb_smallPizza.Text = "Small (8\") +$9.99";
            this.rb_smallPizza.UseVisualStyleBackColor = true;
            this.rb_smallPizza.CheckedChanged += new System.EventHandler(this.rb_smallPizza_CheckedChanged);
            // 
            // gbx_toppings
            // 
            this.gbx_toppings.Controls.Add(this.cb_pineapple);
            this.gbx_toppings.Controls.Add(this.cb_onions);
            this.gbx_toppings.Controls.Add(this.cb_zucchini);
            this.gbx_toppings.Controls.Add(this.cb_tomatoes);
            this.gbx_toppings.Controls.Add(this.cb_olives);
            this.gbx_toppings.Controls.Add(this.cb_mushrooms);
            this.gbx_toppings.Controls.Add(this.cb_sausage);
            this.gbx_toppings.Controls.Add(this.cb_bacon);
            this.gbx_toppings.Controls.Add(this.cb_ham);
            this.gbx_toppings.Controls.Add(this.cb_chicken);
            this.gbx_toppings.Controls.Add(this.cb_pepperoni);
            this.gbx_toppings.Controls.Add(this.cb_cheese);
            this.gbx_toppings.Location = new System.Drawing.Point(603, 293);
            this.gbx_toppings.Name = "gbx_toppings";
            this.gbx_toppings.Size = new System.Drawing.Size(600, 409);
            this.gbx_toppings.TabIndex = 16;
            this.gbx_toppings.TabStop = false;
            this.gbx_toppings.Text = "Toppings + $1.00 (each)";
            // 
            // cb_pineapple
            // 
            this.cb_pineapple.AutoSize = true;
            this.cb_pineapple.Location = new System.Drawing.Point(279, 328);
            this.cb_pineapple.Name = "cb_pineapple";
            this.cb_pineapple.Size = new System.Drawing.Size(247, 55);
            this.cb_pineapple.TabIndex = 11;
            this.cb_pineapple.Text = "Pineapple";
            this.cb_pineapple.UseVisualStyleBackColor = true;
            this.cb_pineapple.CheckedChanged += new System.EventHandler(this.cb_pineapple_CheckedChanged);
            // 
            // cb_onions
            // 
            this.cb_onions.AutoSize = true;
            this.cb_onions.Location = new System.Drawing.Point(279, 276);
            this.cb_onions.Name = "cb_onions";
            this.cb_onions.Size = new System.Drawing.Size(191, 55);
            this.cb_onions.TabIndex = 10;
            this.cb_onions.Text = "Onions";
            this.cb_onions.UseVisualStyleBackColor = true;
            this.cb_onions.CheckedChanged += new System.EventHandler(this.cb_onions_CheckedChanged);
            // 
            // cb_zucchini
            // 
            this.cb_zucchini.AutoSize = true;
            this.cb_zucchini.Location = new System.Drawing.Point(279, 227);
            this.cb_zucchini.Name = "cb_zucchini";
            this.cb_zucchini.Size = new System.Drawing.Size(216, 55);
            this.cb_zucchini.TabIndex = 9;
            this.cb_zucchini.Text = "Zucchini";
            this.cb_zucchini.UseVisualStyleBackColor = true;
            this.cb_zucchini.CheckedChanged += new System.EventHandler(this.cb_zucchini_CheckedChanged);
            // 
            // cb_tomatoes
            // 
            this.cb_tomatoes.AutoSize = true;
            this.cb_tomatoes.Location = new System.Drawing.Point(279, 178);
            this.cb_tomatoes.Name = "cb_tomatoes";
            this.cb_tomatoes.Size = new System.Drawing.Size(246, 55);
            this.cb_tomatoes.TabIndex = 8;
            this.cb_tomatoes.Text = "Tomatoes";
            this.cb_tomatoes.UseVisualStyleBackColor = true;
            this.cb_tomatoes.CheckedChanged += new System.EventHandler(this.cb_tomatoes_CheckedChanged);
            // 
            // cb_olives
            // 
            this.cb_olives.AutoSize = true;
            this.cb_olives.Location = new System.Drawing.Point(279, 123);
            this.cb_olives.Name = "cb_olives";
            this.cb_olives.Size = new System.Drawing.Size(175, 55);
            this.cb_olives.TabIndex = 7;
            this.cb_olives.Text = "Olives";
            this.cb_olives.UseVisualStyleBackColor = true;
            this.cb_olives.CheckedChanged += new System.EventHandler(this.cb_olives_CheckedChanged);
            // 
            // cb_mushrooms
            // 
            this.cb_mushrooms.AutoSize = true;
            this.cb_mushrooms.Location = new System.Drawing.Point(280, 75);
            this.cb_mushrooms.Name = "cb_mushrooms";
            this.cb_mushrooms.Size = new System.Drawing.Size(280, 55);
            this.cb_mushrooms.TabIndex = 6;
            this.cb_mushrooms.Text = "Mushrooms";
            this.cb_mushrooms.UseVisualStyleBackColor = true;
            this.cb_mushrooms.CheckedChanged += new System.EventHandler(this.cb_mushrooms_CheckedChanged);
            // 
            // cb_sausage
            // 
            this.cb_sausage.AutoSize = true;
            this.cb_sausage.Location = new System.Drawing.Point(7, 328);
            this.cb_sausage.Name = "cb_sausage";
            this.cb_sausage.Size = new System.Drawing.Size(225, 55);
            this.cb_sausage.TabIndex = 5;
            this.cb_sausage.Text = "Sausage";
            this.cb_sausage.UseVisualStyleBackColor = true;
            this.cb_sausage.CheckedChanged += new System.EventHandler(this.cb_sausage_CheckedChanged);
            // 
            // cb_bacon
            // 
            this.cb_bacon.AutoSize = true;
            this.cb_bacon.Location = new System.Drawing.Point(7, 276);
            this.cb_bacon.Name = "cb_bacon";
            this.cb_bacon.Size = new System.Drawing.Size(177, 55);
            this.cb_bacon.TabIndex = 4;
            this.cb_bacon.Text = "Bacon";
            this.cb_bacon.UseVisualStyleBackColor = true;
            this.cb_bacon.CheckedChanged += new System.EventHandler(this.cb_bacon_CheckedChanged);
            // 
            // cb_ham
            // 
            this.cb_ham.AutoSize = true;
            this.cb_ham.Location = new System.Drawing.Point(6, 227);
            this.cb_ham.Name = "cb_ham";
            this.cb_ham.Size = new System.Drawing.Size(145, 55);
            this.cb_ham.TabIndex = 3;
            this.cb_ham.Text = "Ham";
            this.cb_ham.UseVisualStyleBackColor = true;
            this.cb_ham.CheckedChanged += new System.EventHandler(this.cb_ham_CheckedChanged);
            // 
            // cb_chicken
            // 
            this.cb_chicken.AutoSize = true;
            this.cb_chicken.Location = new System.Drawing.Point(6, 178);
            this.cb_chicken.Name = "cb_chicken";
            this.cb_chicken.Size = new System.Drawing.Size(211, 55);
            this.cb_chicken.TabIndex = 2;
            this.cb_chicken.Text = "Chicken";
            this.cb_chicken.UseVisualStyleBackColor = true;
            this.cb_chicken.CheckedChanged += new System.EventHandler(this.cb_chicken_CheckedChanged);
            // 
            // cb_pepperoni
            // 
            this.cb_pepperoni.AutoSize = true;
            this.cb_pepperoni.Location = new System.Drawing.Point(6, 123);
            this.cb_pepperoni.Name = "cb_pepperoni";
            this.cb_pepperoni.Size = new System.Drawing.Size(251, 55);
            this.cb_pepperoni.TabIndex = 1;
            this.cb_pepperoni.Text = "Pepperoni";
            this.cb_pepperoni.UseVisualStyleBackColor = true;
            this.cb_pepperoni.CheckedChanged += new System.EventHandler(this.cb_pepperoni_CheckedChanged);
            // 
            // cb_cheese
            // 
            this.cb_cheese.AutoSize = true;
            this.cb_cheese.Location = new System.Drawing.Point(7, 75);
            this.cb_cheese.Name = "cb_cheese";
            this.cb_cheese.Size = new System.Drawing.Size(203, 55);
            this.cb_cheese.TabIndex = 0;
            this.cb_cheese.Text = "Cheese";
            this.cb_cheese.UseVisualStyleBackColor = true;
            this.cb_cheese.CheckedChanged += new System.EventHandler(this.cb_cheese_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbx_sauce
            // 
            this.lbx_sauce.FormattingEnabled = true;
            this.lbx_sauce.ItemHeight = 51;
            this.lbx_sauce.Items.AddRange(new object[] {
            "Tomato",
            "Pesto",
            "None"});
            this.lbx_sauce.Location = new System.Drawing.Point(27, 471);
            this.lbx_sauce.Name = "lbx_sauce";
            this.lbx_sauce.Size = new System.Drawing.Size(473, 157);
            this.lbx_sauce.TabIndex = 13;
            this.lbx_sauce.SelectedIndexChanged += new System.EventHandler(this.lbx_sauce_SelectedIndexChanged);
            // 
            // lbl_toppings
            // 
            this.lbl_toppings.AutoSize = true;
            this.lbl_toppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_toppings.Location = new System.Drawing.Point(715, 220);
            this.lbl_toppings.Name = "lbl_toppings";
            this.lbl_toppings.Size = new System.Drawing.Size(0, 37);
            this.lbl_toppings.TabIndex = 8;
            // 
            // lbl_sauce
            // 
            this.lbl_sauce.AutoSize = true;
            this.lbl_sauce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sauce.Location = new System.Drawing.Point(29, 431);
            this.lbl_sauce.Name = "lbl_sauce";
            this.lbl_sauce.Size = new System.Drawing.Size(107, 37);
            this.lbl_sauce.TabIndex = 6;
            this.lbl_sauce.Text = "Sauce";
            // 
            // lbl_pizza_instrction
            // 
            this.lbl_pizza_instrction.AutoSize = true;
            this.lbl_pizza_instrction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pizza_instrction.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_pizza_instrction.Location = new System.Drawing.Point(464, 135);
            this.lbl_pizza_instrction.Name = "lbl_pizza_instrction";
            this.lbl_pizza_instrction.Size = new System.Drawing.Size(313, 42);
            this.lbl_pizza_instrction.TabIndex = 1;
            this.lbl_pizza_instrction.Text = "Select Your Pizza";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe Print", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_title.Location = new System.Drawing.Point(368, 24);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(508, 102);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "The Pizza Place";
            // 
            // tab_sides
            // 
            this.tab_sides.BackColor = System.Drawing.Color.LightCoral;
            this.tab_sides.Controls.Add(this.label1);
            this.tab_sides.Controls.Add(this.tb_wingQuant);
            this.tab_sides.Controls.Add(this.tb_breadstickQuant);
            this.tab_sides.Controls.Add(this.gbx_sauce);
            this.tab_sides.Controls.Add(this.lbl_wing_quant);
            this.tab_sides.Controls.Add(this.lbl_breadsticks);
            this.tab_sides.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_sides.Location = new System.Drawing.Point(8, 39);
            this.tab_sides.Name = "tab_sides";
            this.tab_sides.Padding = new System.Windows.Forms.Padding(3);
            this.tab_sides.Size = new System.Drawing.Size(1244, 874);
            this.tab_sides.TabIndex = 1;
            this.tab_sides.Text = "Sides";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(446, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sides";
            // 
            // tb_wingQuant
            // 
            this.tb_wingQuant.Location = new System.Drawing.Point(439, 363);
            this.tb_wingQuant.Name = "tb_wingQuant";
            this.tb_wingQuant.Size = new System.Drawing.Size(324, 56);
            this.tb_wingQuant.TabIndex = 6;
            this.tb_wingQuant.Text = "0";
            this.tb_wingQuant.TextChanged += new System.EventHandler(this.tb_wingQuant_TextChanged);
            // 
            // tb_breadstickQuant
            // 
            this.tb_breadstickQuant.Location = new System.Drawing.Point(439, 171);
            this.tb_breadstickQuant.Name = "tb_breadstickQuant";
            this.tb_breadstickQuant.Size = new System.Drawing.Size(324, 56);
            this.tb_breadstickQuant.TabIndex = 5;
            this.tb_breadstickQuant.Text = "0";
            this.tb_breadstickQuant.TextChanged += new System.EventHandler(this.tb_breadstickQuant_TextChanged);
            // 
            // gbx_sauce
            // 
            this.gbx_sauce.Controls.Add(this.rb_bbq);
            this.gbx_sauce.Controls.Add(this.rb_hot);
            this.gbx_sauce.Controls.Add(this.rb_medium);
            this.gbx_sauce.Controls.Add(this.rb_mild);
            this.gbx_sauce.Location = new System.Drawing.Point(12, 96);
            this.gbx_sauce.Name = "gbx_sauce";
            this.gbx_sauce.Size = new System.Drawing.Size(414, 417);
            this.gbx_sauce.TabIndex = 4;
            this.gbx_sauce.TabStop = false;
            this.gbx_sauce.Text = "Wing Sauce";
            // 
            // rb_bbq
            // 
            this.rb_bbq.AutoSize = true;
            this.rb_bbq.Location = new System.Drawing.Point(17, 320);
            this.rb_bbq.Name = "rb_bbq";
            this.rb_bbq.Size = new System.Drawing.Size(238, 55);
            this.rb_bbq.TabIndex = 6;
            this.rb_bbq.TabStop = true;
            this.rb_bbq.Text = "Barbecue";
            this.rb_bbq.UseVisualStyleBackColor = true;
            this.rb_bbq.CheckedChanged += new System.EventHandler(this.rb_bbq_CheckedChanged);
            // 
            // rb_hot
            // 
            this.rb_hot.AutoSize = true;
            this.rb_hot.Location = new System.Drawing.Point(17, 235);
            this.rb_hot.Name = "rb_hot";
            this.rb_hot.Size = new System.Drawing.Size(120, 55);
            this.rb_hot.TabIndex = 5;
            this.rb_hot.TabStop = true;
            this.rb_hot.Text = "Hot";
            this.rb_hot.UseVisualStyleBackColor = true;
            this.rb_hot.CheckedChanged += new System.EventHandler(this.rb_hot_CheckedChanged);
            // 
            // rb_medium
            // 
            this.rb_medium.AutoSize = true;
            this.rb_medium.Location = new System.Drawing.Point(17, 160);
            this.rb_medium.Name = "rb_medium";
            this.rb_medium.Size = new System.Drawing.Size(207, 55);
            this.rb_medium.TabIndex = 4;
            this.rb_medium.TabStop = true;
            this.rb_medium.Text = "Medium";
            this.rb_medium.UseVisualStyleBackColor = true;
            this.rb_medium.CheckedChanged += new System.EventHandler(this.rb_medium_CheckedChanged);
            // 
            // rb_mild
            // 
            this.rb_mild.AutoSize = true;
            this.rb_mild.Location = new System.Drawing.Point(17, 75);
            this.rb_mild.Name = "rb_mild";
            this.rb_mild.Size = new System.Drawing.Size(133, 55);
            this.rb_mild.TabIndex = 3;
            this.rb_mild.TabStop = true;
            this.rb_mild.Text = "Mild";
            this.rb_mild.UseVisualStyleBackColor = true;
            this.rb_mild.CheckedChanged += new System.EventHandler(this.rb_mild_CheckedChanged);
            // 
            // lbl_wing_quant
            // 
            this.lbl_wing_quant.AutoSize = true;
            this.lbl_wing_quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wing_quant.Location = new System.Drawing.Point(432, 284);
            this.lbl_wing_quant.Name = "lbl_wing_quant";
            this.lbl_wing_quant.Size = new System.Drawing.Size(494, 42);
            this.lbl_wing_quant.TabIndex = 2;
            this.lbl_wing_quant.Text = "Wing Quantity +$1.00 (each)";
            // 
            // lbl_breadsticks
            // 
            this.lbl_breadsticks.AutoSize = true;
            this.lbl_breadsticks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_breadsticks.Location = new System.Drawing.Point(425, 96);
            this.lbl_breadsticks.Name = "lbl_breadsticks";
            this.lbl_breadsticks.Size = new System.Drawing.Size(584, 42);
            this.lbl_breadsticks.TabIndex = 0;
            this.lbl_breadsticks.Text = "Breadstick Quantity +$0.75 (each)";
            // 
            // tab_drinks
            // 
            this.tab_drinks.BackColor = System.Drawing.Color.LightCoral;
            this.tab_drinks.Controls.Add(this.gbx_drinks);
            this.tab_drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_drinks.Location = new System.Drawing.Point(8, 39);
            this.tab_drinks.Name = "tab_drinks";
            this.tab_drinks.Padding = new System.Windows.Forms.Padding(3);
            this.tab_drinks.Size = new System.Drawing.Size(1244, 874);
            this.tab_drinks.TabIndex = 2;
            this.tab_drinks.Text = "Drinks";
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(759, 958);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(193, 87);
            this.btn_order.TabIndex = 9;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(515, 959);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(193, 87);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(530, 1141);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 51);
            this.lbl_total.TabIndex = 11;
            // 
            // gbx_crust
            // 
            this.gbx_crust.Controls.Add(this.rb_veggie);
            this.gbx_crust.Controls.Add(this.rb_supreme);
            this.gbx_crust.Controls.Add(this.rb_original);
            this.gbx_crust.Location = new System.Drawing.Point(27, 634);
            this.gbx_crust.Name = "gbx_crust";
            this.gbx_crust.Size = new System.Drawing.Size(483, 217);
            this.gbx_crust.TabIndex = 18;
            this.gbx_crust.TabStop = false;
            this.gbx_crust.Text = "Crust";
            // 
            // rb_original
            // 
            this.rb_original.AutoSize = true;
            this.rb_original.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_original.Location = new System.Drawing.Point(20, 55);
            this.rb_original.Name = "rb_original";
            this.rb_original.Size = new System.Drawing.Size(159, 41);
            this.rb_original.TabIndex = 0;
            this.rb_original.TabStop = true;
            this.rb_original.Text = "Original";
            this.rb_original.UseVisualStyleBackColor = true;
            this.rb_original.CheckedChanged += new System.EventHandler(this.rb_original_CheckedChanged);
            // 
            // rb_supreme
            // 
            this.rb_supreme.AutoSize = true;
            this.rb_supreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_supreme.Location = new System.Drawing.Point(21, 104);
            this.rb_supreme.Name = "rb_supreme";
            this.rb_supreme.Size = new System.Drawing.Size(293, 41);
            this.rb_supreme.TabIndex = 1;
            this.rb_supreme.TabStop = true;
            this.rb_supreme.Text = "Supreme + $1.50";
            this.rb_supreme.UseVisualStyleBackColor = true;
            this.rb_supreme.CheckedChanged += new System.EventHandler(this.rb_supreme_CheckedChanged);
            // 
            // rb_veggie
            // 
            this.rb_veggie.AutoSize = true;
            this.rb_veggie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_veggie.Location = new System.Drawing.Point(20, 161);
            this.rb_veggie.Name = "rb_veggie";
            this.rb_veggie.Size = new System.Drawing.Size(263, 41);
            this.rb_veggie.TabIndex = 2;
            this.rb_veggie.TabStop = true;
            this.rb_veggie.Text = "Veggie + $1.50";
            this.rb_veggie.UseVisualStyleBackColor = true;
            this.rb_veggie.CheckedChanged += new System.EventHandler(this.rb_veggie_CheckedChanged);
            // 
            // gbx_drinks
            // 
            this.gbx_drinks.Controls.Add(this.rb_none);
            this.gbx_drinks.Controls.Add(this.rb_water);
            this.gbx_drinks.Controls.Add(this.rb_tea);
            this.gbx_drinks.Controls.Add(this.rb_soda);
            this.gbx_drinks.Location = new System.Drawing.Point(372, 154);
            this.gbx_drinks.Name = "gbx_drinks";
            this.gbx_drinks.Size = new System.Drawing.Size(494, 423);
            this.gbx_drinks.TabIndex = 3;
            this.gbx_drinks.TabStop = false;
            this.gbx_drinks.Text = "Drinks (+$1.50)";
            // 
            // rb_soda
            // 
            this.rb_soda.AutoSize = true;
            this.rb_soda.Location = new System.Drawing.Point(21, 83);
            this.rb_soda.Name = "rb_soda";
            this.rb_soda.Size = new System.Drawing.Size(154, 55);
            this.rb_soda.TabIndex = 0;
            this.rb_soda.TabStop = true;
            this.rb_soda.Text = "Soda";
            this.rb_soda.UseVisualStyleBackColor = true;
            this.rb_soda.CheckedChanged += new System.EventHandler(this.rb_soda_CheckedChanged);
            // 
            // rb_tea
            // 
            this.rb_tea.AutoSize = true;
            this.rb_tea.Location = new System.Drawing.Point(21, 169);
            this.rb_tea.Name = "rb_tea";
            this.rb_tea.Size = new System.Drawing.Size(127, 55);
            this.rb_tea.TabIndex = 1;
            this.rb_tea.TabStop = true;
            this.rb_tea.Text = "Tea";
            this.rb_tea.UseVisualStyleBackColor = true;
            this.rb_tea.CheckedChanged += new System.EventHandler(this.rb_tea_CheckedChanged);
            // 
            // rb_water
            // 
            this.rb_water.AutoSize = true;
            this.rb_water.Location = new System.Drawing.Point(21, 258);
            this.rb_water.Name = "rb_water";
            this.rb_water.Size = new System.Drawing.Size(168, 55);
            this.rb_water.TabIndex = 2;
            this.rb_water.TabStop = true;
            this.rb_water.Text = "Water";
            this.rb_water.UseVisualStyleBackColor = true;
            this.rb_water.CheckedChanged += new System.EventHandler(this.rb_water_CheckedChanged);
            // 
            // rb_none
            // 
            this.rb_none.AutoSize = true;
            this.rb_none.Location = new System.Drawing.Point(21, 344);
            this.rb_none.Name = "rb_none";
            this.rb_none.Size = new System.Drawing.Size(156, 55);
            this.rb_none.TabIndex = 3;
            this.rb_none.TabStop = true;
            this.rb_none.Text = "None";
            this.rb_none.UseVisualStyleBackColor = true;
            this.rb_none.CheckedChanged += new System.EventHandler(this.rb_none_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1262, 1351);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.tbx_email);
            this.Controls.Add(this.tbx_phone);
            this.Controls.Add(this.tbx_address);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_pizza.ResumeLayout(false);
            this.tab_pizza.PerformLayout();
            this.gbx_size.ResumeLayout(false);
            this.gbx_size.PerformLayout();
            this.gbx_toppings.ResumeLayout(false);
            this.gbx_toppings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab_sides.ResumeLayout(false);
            this.tab_sides.PerformLayout();
            this.gbx_sauce.ResumeLayout(false);
            this.gbx_sauce.PerformLayout();
            this.tab_drinks.ResumeLayout(false);
            this.gbx_crust.ResumeLayout(false);
            this.gbx_crust.PerformLayout();
            this.gbx_drinks.ResumeLayout(false);
            this.gbx_drinks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_address;
        private System.Windows.Forms.TextBox tbx_phone;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_pizza;
        private System.Windows.Forms.TabPage tab_sides;
        private System.Windows.Forms.TabPage tab_drinks;
        private System.Windows.Forms.Label lbl_pizza_instrction;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_toppings;
        private System.Windows.Forms.Label lbl_sauce;
        private System.Windows.Forms.ListBox lbx_sauce;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_wing_quant;
        private System.Windows.Forms.Label lbl_breadsticks;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.GroupBox gbx_sauce;
        private System.Windows.Forms.RadioButton rb_bbq;
        private System.Windows.Forms.RadioButton rb_hot;
        private System.Windows.Forms.RadioButton rb_medium;
        private System.Windows.Forms.RadioButton rb_mild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_wingQuant;
        private System.Windows.Forms.TextBox tb_breadstickQuant;
        private System.Windows.Forms.GroupBox gbx_toppings;
        private System.Windows.Forms.CheckBox cb_pineapple;
        private System.Windows.Forms.CheckBox cb_onions;
        private System.Windows.Forms.CheckBox cb_zucchini;
        private System.Windows.Forms.CheckBox cb_tomatoes;
        private System.Windows.Forms.CheckBox cb_olives;
        private System.Windows.Forms.CheckBox cb_mushrooms;
        private System.Windows.Forms.CheckBox cb_sausage;
        private System.Windows.Forms.CheckBox cb_bacon;
        private System.Windows.Forms.CheckBox cb_ham;
        private System.Windows.Forms.CheckBox cb_chicken;
        private System.Windows.Forms.CheckBox cb_pepperoni;
        private System.Windows.Forms.CheckBox cb_cheese;
        private System.Windows.Forms.GroupBox gbx_size;
        private System.Windows.Forms.RadioButton rb_largePizza;
        private System.Windows.Forms.RadioButton rb_mediumPizza;
        private System.Windows.Forms.RadioButton rb_smallPizza;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbx_crust;
        private System.Windows.Forms.RadioButton rb_original;
        private System.Windows.Forms.RadioButton rb_veggie;
        private System.Windows.Forms.RadioButton rb_supreme;
        private System.Windows.Forms.GroupBox gbx_drinks;
        private System.Windows.Forms.RadioButton rb_water;
        private System.Windows.Forms.RadioButton rb_tea;
        private System.Windows.Forms.RadioButton rb_soda;
        private System.Windows.Forms.RadioButton rb_none;
    }
}

