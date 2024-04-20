  using System.Media;
using System.Timers;
namespace jangfazaee
{
    public partial class seve : Form
    {
        SoundPlayer Gameover = new SoundPlayer();
        SoundPlayer shelik = new SoundPlayer();
        SoundPlayer Speed = new SoundPlayer();
        SoundPlayer AI = new SoundPlayer();

        int y;
        int x;
        int coin = 0;
        int interval;
        string best;
        bool sev = false;
        int BEST;
        int sum = 0;
        int se = 4;
        int sj = 23;
        int sg = 20;
        int nl = 20;
        int bigl = 249;
        bool GM = false;
        int scor = 5;
        int ni = 1;
        int h = 0;
        int life;
        int tir = 0;
        int BIG = 20;
        int bigshot = 0;
        int n = 0;
        string cheet;
        bool space = false;
        int shl1 = -510;
        int shl2 = 440;
        int interval2;
        int chekbigshot = 1000;
        int locationai1;
        int locationai2;
        int locationai3;
        bool chekai1 = false;
        bool chekai2 = false;
        bool chekai3 = false;
        int i = 1;
        bool bigshotai = false;
        PictureBox golole;
        PictureBox enfejar = new PictureBox();
        bool contorol = false;

        public seve(int PLAYER, int GOLOLE, int PLAYER2, int GOLOLE2, string speed)
        {

            InitializeComponent();
            best = File.ReadAllText(Environment.CurrentDirectory + @"\Bestscore.txt");
            bestscore.Text = best;
            score.Text = sum + "";
            cheetcode.Hide();
            heart.Hide();
            heart11.Hide();
            heart12.Hide();
            s.Hide();
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Tag == "Coin")
                {
                    c.Hide();
                }
            }
            timer5.Stop();
            timer8.Stop();
            timer12.Stop();
            timer13.Stop();
            timer14.Stop();
            timer15.Stop();
            timer16.Stop();
            timer17.Stop();
            if (PLAYER == 1)
            {
                player.Image = Properties.Resources.jet2;
            }
            if (PLAYER == 2)
            {
                player.Image = Properties.Resources.player1;

            }
            if (PLAYER == 3)
            {
                player.Image = Properties.Resources.space_jet11;
            }
            if (GOLOLE == 1)
            {
                tir = 1;
                life = 2;
            }
            if (GOLOLE == 2)
            {
                tir = 2;
                life = 1;

            }
            if (GOLOLE == 3)
            {
                tir = 3;
                life = 0;
            }
            if (speed == "e")
            {
                se = 2;
            }
            if (speed == "m")
            {
                se = 6;
                timer15.Start();
                timer16.Start();

            }
            if (speed == "i")
            {
                se = 12;
                timer12.Start();
                timer15.Start();
                timer16.Start();
            }
        }

        int Randomm()
        {
            Random rnd = new Random();
            y = rnd.Next(0, 690);
            return y;
        }

        void harekatenemi()
        {
            if (enemi1.Top > 475)
            {
                locationai1 = Randomm();
                enemi1.Location = new Point(locationai1, 0);
                sum++;
            }
            else
            {
                enemi1.Top += se;
            }
            if (enemi2.Top > 475)
            {
                locationai2 = Randomm();
                enemi2.Location = new Point(locationai2, 0);
                sum++;
            }
            else
            {
                enemi2.Top += se;
            }
            if (enemi3.Top > 475)
            {
                locationai3 = Randomm();
                enemi3.Location = new Point(locationai3, 0);
                sum++;
            }
            else
            {
                enemi3.Top += se;
            }
        }

        void gameover()
        {
            if (enemi1.Bounds.IntersectsWith(player.Bounds))
            {
                if (GM == false)
                {
                    if (h == 0)
                    {
                        h += 1;
                    }
                    if (h == 1)
                    {
                        this.Controls.Remove(heart1);
                        heart11.Hide();
                        h += 1;
                        locationai1= Randomm();
                        enemi1.Location = new Point(locationai1, 0);
                        if (tir == 1)
                        {
                            life = 2;
                        }
                        else if (tir == 2)
                        {
                            life = 1;
                        }
                        else if (tir == 3)
                        {
                            life = 0;
                        }
                    }
                    else if (h == 2)
                    {
                        this.Controls.Remove(heart2);
                        heart12.Hide();
                        h += 1;
                        locationai1 = Randomm();
                        enemi1.Location = new Point(locationai1, 0);

                        if (tir == 1)
                        {
                            life = 2;
                        }
                        else if (tir == 2)
                        {
                            life = 1;
                        }
                        else if (tir == 3)
                        {
                            life = 0;
                        }
                    }
                    else if (h == 3)
                    {

                        Gameover.SoundLocation = Environment.CurrentDirectory + @"\aspose_Game-Over-Sound-Effect-4.wav";
                        Gameover.Play();
                        this.Controls.Remove(heart3);
                        h += 1;
                        reastart.Location = new Point(300, 390);
                        s.Show();
                        s.Location = new Point(370, 382);
                        timer1.Stop();
                        timer2.Stop();
                        timer3.Stop();
                        timer4.Stop();
                        timer5.Stop();
                        timer6.Stop();
                        timer7.Stop();
                        timer8.Stop();
                        timer10.Stop();
                        timer9.Stop();
                        timer11.Stop();
                        timer12.Stop();
                        timer13.Stop();
                        timer14.Stop();
                        timer15.Stop();
                        timer16.Stop();
                        timer17.Stop();

                        label1.Location = new Point(63, 209);

                    }

                }
            }

            if (enemi2.Bounds.IntersectsWith(player.Bounds))
            {

                if (GM == false)
                {
                    if (h == 0)
                    {
                        h += 1;
                    }
                    if (h == 1)
                    {
                        this.Controls.Remove(heart1);
                        heart11.Hide();
                        h += 1;
                        locationai2 = Randomm();

                        enemi2.Location = new Point(locationai2, 0);

                        if (tir == 1)
                        {
                            life = 2;
                        }
                        else if (tir == 2)
                        {
                            life = 1;
                        }
                        else if (tir == 3)
                        {
                            life = 0;
                        }
                    }
                    else if (h == 2)
                    {
                        this.Controls.Remove(heart2);
                        heart12.Hide();
                        h += 1;
                        locationai2 = Randomm();
                        enemi2.Location = new Point(locationai2, 0);

                        if (tir == 1)
                        {
                            life = 2;
                        }
                        else if (tir == 2)
                        {
                            life = 1;
                        }
                        else if (tir == 3)
                        {
                            life = 0;
                        }
                    }
                    else if (h == 3)
                    {

                        Gameover.SoundLocation = Environment.CurrentDirectory + @"\aspose_Game-Over-Sound-Effect-4.wav";
                        Gameover.Play();
                        this.Controls.Remove(heart3);
                        h += 1;
                        reastart.Location = new Point(300, 390);
                        s.Show();
                        s.Location = new Point(370, 382);
                        timer1.Stop();
                        timer2.Stop();
                        timer3.Stop();
                        timer4.Stop();
                        timer5.Stop();
                        timer6.Stop();
                        timer7.Stop();
                        timer8.Stop();
                        timer10.Stop();
                        timer9.Stop();
                        timer11.Stop();
                        timer12.Stop();
                        timer13.Stop();
                        timer14.Stop();
                        timer15.Stop();
                        timer16.Stop();
                        timer17.Stop();

                        label1.Location = new Point(63, 209);

                    }

                }
            }

            if (enemi3.Bounds.IntersectsWith(player.Bounds))
            {

                if (GM == false)
                {
                    if (h == 0)
                    {
                        h += 1;
                    }
                    if (h == 1)
                    {
                        this.Controls.Remove(heart1);
                        heart11.Hide();
                        h += 1;
                        locationai3 = Randomm();

                        enemi3.Location = new Point(locationai3, 0);

                        if (tir == 1)
                        {
                            life = 2;
                        }
                        else if (tir == 2)
                        {
                            life = 1;
                        }
                        else if (tir == 3)
                        {
                            life = 0;
                        }
                    }
                    else if (h == 2)
                    {
                        this.Controls.Remove(heart2);
                        heart12.Hide();

                        h += 1;
                        locationai3 = Randomm();

                        enemi3.Location = new Point(locationai3, 0);

                        if (tir == 1)
                        {
                            life = 2;
                        }
                        else if (tir == 2)
                        {
                            life = 1;
                        }
                        else if (tir == 3)
                        {
                            life = 0;
                        }
                    }
                    else if (h == 3)
                    {

                        Gameover.SoundLocation = Environment.CurrentDirectory + @"\aspose_Game-Over-Sound-Effect-4.wav";
                        Gameover.Play();
                        this.Controls.Remove(heart3);
                        h += 1;
                        reastart.Location = new Point(300, 390);
                        s.Show();
                        s.Location = new Point(370, 382);
                        timer1.Stop();
                        timer2.Stop();
                        timer3.Stop();
                        timer4.Stop();
                        timer5.Stop();
                        timer6.Stop();
                        timer7.Stop();
                        timer8.Stop();
                        timer10.Stop();
                        timer9.Stop();
                        timer11.Stop();
                        timer12.Stop();
                        timer13.Stop();
                        timer14.Stop();
                        timer15.Stop();
                        timer16.Stop();
                        timer17.Stop();

                        label1.Location = new Point(63, 209);

                    }

                }
            }
        }

        void gameover_big_player()
        {
            if (GM == false)
            {
                if (h == 0)
                {
                    h += 1;
                }
                if (h == 1)
                {
                    this.Controls.Remove(heart1);
                    heart11.Hide();
                    h += 1;


                    if (tir == 1)
                    {
                        life = 2;
                    }
                    else if (tir == 2)
                    {
                        life = 1;
                    }
                    else if (tir == 3)
                    {
                        life = 0;
                    }
                }
                else if (h == 2)
                {
                    this.Controls.Remove(heart2);
                    heart12.Hide();

                    h += 1;


                    if (tir == 1)
                    {
                        life = 2;
                    }
                    else if (tir == 2)
                    {
                        life = 1;
                    }
                    else if (tir == 3)
                    {
                        life = 0;
                    }
                }
                else if (h == 3)
                {

                    Gameover.SoundLocation = Environment.CurrentDirectory + @"\aspose_Game-Over-Sound-Effect-4.wav";
                    Gameover.Play();
                    this.Controls.Remove(heart3);
                    h += 1;
                    reastart.Location = new Point(300, 390);
                    s.Show();
                    s.Location = new Point(370, 382);
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    timer4.Stop();
                    timer5.Stop();
                    timer6.Stop();
                    timer7.Stop();
                    timer8.Stop();
                    timer10.Stop();
                    timer9.Stop();
                    timer11.Stop();
                    timer12.Stop();
                    timer13.Stop();
                    timer14.Stop();
                    timer15.Stop();
                    timer16.Stop();
                    timer17.Stop();
                    label1.Location = new Point(63, 209);

                }

            }
        }

        void gameover_shamshir()
        {
            if (GM == false)
            {
                if (h == 0)
                {
                    h += 1;
                }
                if (h == 1)
                {
                    this.Controls.Remove(heart1);
                    heart11.Hide();
                    h += 1;
                    enemi1.Location = new Point(Randomm(), 0);

                    if (tir == 1)
                    {
                        life = 2;
                    }
                    else if (tir == 2)
                    {
                        life = 1;
                    }
                    else if (tir == 3)
                    {
                        life = 0;
                    }
                }
                else if (h == 2)
                {
                    this.Controls.Remove(heart2);
                    heart12.Hide();

                    h += 1;
                    enemi1.Location = new Point(Randomm(), 0);

                    if (tir == 1)
                    {
                        life = 2;
                    }
                    else if (tir == 2)
                    {
                        life = 1;
                    }
                    else if (tir == 3)
                    {
                        life = 0;
                    }
                }
                else if (h == 3)
                {

                    Gameover.SoundLocation = Environment.CurrentDirectory + @"\aspose_Game-Over-Sound-Effect-4.wav";
                    Gameover.Play();
                    this.Controls.Remove(heart3);
                    h += 1;
                    reastart.Location = new Point(300, 390);
                    s.Show();
                    s.Location = new Point(370, 382);
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    timer4.Stop();
                    timer5.Stop();
                    timer6.Stop();
                    timer7.Stop();
                    timer8.Stop();
                    timer10.Stop();
                    timer9.Stop();
                    timer11.Stop();
                    timer12.Stop();
                    timer13.Stop();
                    timer14.Stop();
                    timer15.Stop();
                    timer16.Stop();
                    timer17.Stop();
                    label1.Location = new Point(63, 209);

                }
            }
        }

        void goolole()
        {
            golole = new PictureBox();
            if (tir == 1)
            {
                golole.Image = Properties.Resources.bullet2;
            }
            if (tir == 2)
            {
                golole.Image = Properties.Resources.Asset;
            }
            if (tir == 3)
            {
                golole.Image = Properties.Resources.bullet35;
            }
            golole.SizeMode = PictureBoxSizeMode.AutoSize;
            golole.Left = player.Left + 30;
            golole.Top = player.Top - 40;
            golole.Tag = "gololee";
            golole.BackColor = Color.Transparent;
            this.Controls.Add(golole);
        }

        void shelick()
        {
            if (golole != null)
            {
                //shelick
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "gololee")
                    {
                        x.Top -= sg;
                        if (x.Top < 100)
                        {
                            this.Controls.Remove(x);
                        }

                        //...

                        //enemi shot
                        if (sum > BIG)
                        {
                            if (big.Bounds.IntersectsWith(x.Bounds))
                            {
                                bigshot++;
                                if (bigshot >= chekbigshot)
                                {
                                    timer9.Start();
                                    BIG += 30;
                                    bigshot = 0;
                                    big.Visible = false;
                                    foreach (Control c in this.Controls)
                                    {
                                        if (c is PictureBox && c.Tag == "big b")
                                        {
                                            c.Visible = false;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {


                            if (enemi1.Bounds.IntersectsWith(x.Bounds))
                            {
                                if (life == 2)
                                {
                                    life -= 1;
                                    this.Controls.Remove(x);
                                    this.Controls.Remove(golole);

                                }

                                else if (life == 1)
                                {
                                    life -= 1;
                                    this.Controls.Remove(x);
                                    this.Controls.Remove(golole);

                                }
                                else if (life == 0)
                                {
                                    chekai1 = true;
                                    contorol = true;
                                    this.Controls.Add(enfejar);
                                    enfejar.Image = Properties.Resources.Screenshot__14_;
                                    enfejar.SizeMode = PictureBoxSizeMode.AutoSize;
                                    enfejar.Left = enemi1.Left;
                                    enfejar.Top = enemi1.Top;
                                    enfejar.BackColor = Color.Transparent;
                                    this.Controls.Remove(x);

                                    locationai1 = Randomm();
                                    enemi1.Location = new Point(locationai1, 0);

                                    sum += 2;
                                    if (sum >= scor)
                                    {
                                        scor += 5;
                                        se++;
                                    }
                                    if (sum >= nl)
                                    {
                                        if (ni % 2 == 1)
                                        {
                                            this.BackgroundImage = Properties.Resources.warped_space_chromebook_wallpaper;
                                            //BackColor = Color.Cyan;
                                            ni++;
                                        }
                                        else if (ni % 2 == 0)
                                        {
                                            this.BackgroundImage = Properties.Resources.pngtree_3d_planets_in_space_wallpapers_for_mobile_picture_image_2670749;
                                            //BackColor = Color.Navy;
                                            ni++;

                                        }
                                        nl += 20;
                                    }
                                    score.Text = sum + "";
                                    if (tir == 1)
                                    {
                                        life = 2;
                                    }
                                    else if (tir == 2)
                                    {
                                        life = 1;
                                    }
                                    else if (tir == 3)
                                    {
                                        life = 0;
                                    }
                                }
                            }

                            if (enemi2.Bounds.IntersectsWith(x.Bounds))
                            {
                                if (life == 2)
                                {
                                    life -= 1;
                                    this.Controls.Remove(x);
                                    this.Controls.Remove(golole);

                                }

                                else if (life == 1)
                                {
                                    life -= 1;
                                    this.Controls.Remove(x);
                                    this.Controls.Remove(golole);

                                }
                                else if (life == 0)
                                {
                                    chekai2 = true;
                                    contorol = true;
                                    this.Controls.Add(enfejar);
                                    enfejar.Image = Properties.Resources.Screenshot__14_;
                                    enfejar.SizeMode = PictureBoxSizeMode.AutoSize;
                                    enfejar.Left = enemi1.Left;
                                    enfejar.Top = enemi1.Top;
                                    enfejar.BackColor = Color.Transparent;
                                    this.Controls.Remove(x);

                                    locationai2 = Randomm();
                                    enemi2.Location = new Point(locationai2, 0);

                                    sum += 2;
                                    if (sum >= scor)
                                    {
                                        scor += 5;
                                        se++;
                                    }
                                    if (sum >= nl)
                                    {
                                        if (ni % 2 == 1)
                                        {
                                            this.BackgroundImage = Properties.Resources.warped_space_chromebook_wallpaper;
                                            //BackColor = Color.Cyan;
                                            ni++;
                                        }
                                        else if (ni % 2 == 0)
                                        {
                                            this.BackgroundImage = Properties.Resources.pngtree_3d_planets_in_space_wallpapers_for_mobile_picture_image_2670749;
                                            //BackColor = Color.Navy;
                                            ni++;

                                        }
                                        nl += 20;
                                    }
                                    score.Text = sum + "";
                                    if (tir == 1)
                                    {
                                        life = 2;
                                    }
                                    else if (tir == 2)
                                    {
                                        life = 1;
                                    }
                                    else if (tir == 3)
                                    {
                                        life = 0;
                                    }
                                }
                            }

                            if (enemi3.Bounds.IntersectsWith(x.Bounds))
                            {
                                if (life == 2)
                                {
                                    life -= 1;
                                    this.Controls.Remove(x);
                                    this.Controls.Remove(golole);

                                }

                                else if (life == 1)
                                {
                                    life -= 1;
                                    this.Controls.Remove(x);
                                    this.Controls.Remove(golole);

                                }
                                else if (life == 0)
                                {
                                    chekai3 = true;
                                    contorol = true;
                                    this.Controls.Add(enfejar);
                                    enfejar.Image = Properties.Resources.Screenshot__14_;
                                    enfejar.SizeMode = PictureBoxSizeMode.AutoSize;
                                    enfejar.Left = enemi1.Left;
                                    enfejar.Top = enemi1.Top;
                                    enfejar.BackColor = Color.Transparent;
                                    this.Controls.Remove(x);

                                    locationai3 = Randomm();
                                    enemi3.Location = new Point(locationai3, 0);

                                    sum += 2;
                                    if (sum >= scor)
                                    {
                                        scor += 5;
                                        se++;
                                    }
                                    if (sum >= nl)
                                    {
                                        if (ni % 2 == 1)
                                        {
                                            this.BackgroundImage = Properties.Resources.warped_space_chromebook_wallpaper;
                                            //BackColor = Color.Cyan;
                                            ni++;
                                        }
                                        else if (ni % 2 == 0)
                                        {
                                            this.BackgroundImage = Properties.Resources.pngtree_3d_planets_in_space_wallpapers_for_mobile_picture_image_2670749;
                                            //BackColor = Color.Navy;
                                            ni++;

                                        }
                                        nl += 20;
                                    }
                                    score.Text = sum + "";
                                    if (tir == 1)
                                    {
                                        life = 2;
                                    }
                                    else if (tir == 2)
                                    {
                                        life = 1;
                                    }
                                    else if (tir == 3)
                                    {
                                        life = 0;
                                    }
                                }
                            }
                        }
                        //...
                    }
                }
            }
        }

        //void enemishot()
        //{
        //    if (golole != null)
        //    {
        //        if (enemi.Bounds.IntersectsWith(golole.Bounds))
        //        {
        //            contorol = true;
        //            this.Controls.Add(enfejar);
        //            enfejar.Image = Properties.Resources.Screenshot__14_;
        //            enfejar.SizeMode = PictureBoxSizeMode.AutoSize;
        //            enfejar.Left = enemi.Left;
        //            enfejar.Top = enemi.Top;
        //            enfejar.BackColor = Color.Transparent;
        //            this.Controls.Remove(golole);
        //            Random rnd = new Random();
        //            y = rnd.Next(0, 690);
        //            enemi.Location = new Point(y, 0);
        //            sum += 2;
        //            if (sum >= scor)
        //            {
        //                scor += 5;
        //                se++;
        //            }
        //            if (sum >= nl)
        //            {
        //                if (ni % 2 == 1)
        //                {
        //                    this.BackgroundImage = Properties.Resources.warped_space_chromebook_wallpaper;
        //                    //BackColor = Color.Cyan;
        //                    ni++;
        //                }
        //                else if (ni % 2 == 0)
        //                {
        //                    this.BackgroundImage = Properties.Resources.pngtree_3d_planets_in_space_wallpapers_for_mobile_picture_image_2670749;
        //                    //BackColor = Color.Navy;
        //                    ni++;
        //                }
        //                nl += 20;
        //            }
        //            score.Text = sum + "";
        //        }
        //    }
        //}

        void Randomheart()
        {

            if (heart.Top > 475)
            {
                heart.Location = new Point(Randomm(), 0);
                heart.Hide();
                timer6.Stop();
            }
            else
            {
                heart.Show();
                heart.Top += 20;
            }
        }

        void getheart()
        {
            if (heart.Bounds.IntersectsWith(player.Bounds))
            {

                heart.Location = new Point(Randomm(), -50);
                if (h == 2)
                {
                    heart11.Show();
                    h -= 1;
                }
                else if (h == 3)
                {
                    heart12.Show();
                    h -= 1;

                }
                timer6.Stop();

            }
        }

        void bigenemi()
        {
            if (sum > BIG)
            {
                n++;
                timer9.Stop();
                big.Visible = true;
                enemi1.Location = new Point(900, 800);
                enemi2.Location = new Point(900, 800);
                enemi3.Location = new Point(900, 800);
                foreach (Control c in this.Controls)
                {
                    if (c is PictureBox && c.Tag == "big b")
                    {
                        if (c.Top >= 470)
                        {
                            c.Top = bigl;
                        }
                    }
                }
                foreach (Control c in this.Controls)
                {
                    if (c is PictureBox && c.Tag == "big b")
                    {
                        c.Visible = true;
                    }
                }
                foreach (Control c in this.Controls)
                {
                    if (c is PictureBox && c.Tag == "big b")
                    {
                        c.Top += 6;
                    }
                }
                foreach (Control c in this.Controls)
                {
                    if (c is PictureBox && c.Tag == "big b")
                    {
                        if (c.Bounds.IntersectsWith(player.Bounds))
                        {
                            gameover_big_player();
                             GM = true;
                            timer11.Start();
                        }
                        shelick();
                    }
                }
                if (n == 180)
                {
                    BIG += 30;
                    n = 0;
                }
            }
            else
            {
                timer9.Start();
                big.Hide();
                foreach (Control c in this.Controls)
                {
                    if (c is PictureBox && c.Tag == "big b")
                    {
                        c.Top = bigl;
                    }
                }
                foreach (Control c in this.Controls)
                {
                    if (c is PictureBox && c.Tag == "big b")
                    {
                        c.Visible = false;
                    }
                }

            }
        }

        void shemshir()
        {
            foreach (Control a in this.Controls)
            {
                if (a is PictureBox && a.Tag == "shamshir")
                {
                    if (shl22.Left >= shl2)
                    {
                        a.Left -= 15;
                    }
                    else
                    {

                        timer14.Start();
                    }
                    if (a.Bounds.IntersectsWith(player.Bounds))
                    {
                        gameover_shamshir();
                    }
                }
                if (a is PictureBox && a.Tag == "shamshir2")
                {
                    if (shl11.Left <= shl1)
                    {
                        a.Left += 15;
                    }
                    else
                    {
                        timer14.Start();
                    }
                    if (a.Bounds.IntersectsWith(player.Bounds))
                    {
                        gameover_shamshir();
                    }
                }

            }
        }

        void random_tnt()
        {

            if (tnt1.Top > 475)
            {

                tnt1.Location = new Point(Randomm(), 0);

                tnt2.Location = new Point(Randomm(), 0);

                tnt3.Location = new Point(Randomm(), 0);

                tnt1.Hide();
                tnt2.Hide();
                tnt3.Hide();
                timer15.Stop();

            }
            else
            {
                tnt1.Show();
                tnt1.Top += 30;
            }
            if (tnt2.Top > 475)
            {

                tnt2.Location = new Point(Randomm(), 0);

                tnt1.Location = new Point(Randomm(), 0);

                tnt3.Location = new Point(Randomm(), 0);

                tnt1.Hide();
                tnt2.Hide();
                tnt3.Hide();
                timer15.Stop();

            }
            else
            {
                tnt2.Show();
                tnt2.Top += 30;
            }
            if (tnt3.Top > 475)
            {

                tnt3.Location = new Point(Randomm(), 0);

                tnt2.Location = new Point(Randomm(), 0);

                tnt1.Location = new Point(Randomm(), 0);
                tnt1.Hide();
                tnt2.Hide();
                tnt3.Hide();
                timer15.Stop();

            }
            else
            {
                tnt3.Show();
                tnt3.Top += 30;
            }



            if (tnt1.Bounds.IntersectsWith(player.Bounds))
            {

                tnt1.Location = new Point(Randomm(), 0);

                tnt2.Location = new Point(Randomm(), 0);

                tnt3.Location = new Point(Randomm(), 0);

                tnt1.Hide();
                tnt2.Hide();
                tnt3.Hide();

                gameover_shamshir();
                timer15.Stop();


            }
            if (tnt2.Bounds.IntersectsWith(player.Bounds))
            {
                tnt1.Location = new Point(Randomm(), 0);

                tnt2.Location = new Point(Randomm(), 0);

                tnt3.Location = new Point(Randomm(), 0);

                tnt1.Hide();
                tnt2.Hide();
                tnt3.Hide();

                gameover_shamshir();
                timer15.Stop();


            }
            if (tnt3.Bounds.IntersectsWith(player.Bounds))
            {
                tnt1.Location = new Point(Randomm(), 0);

                tnt2.Location = new Point(Randomm(), 0);

                tnt3.Location = new Point(Randomm(), 0);

                tnt1.Hide();
                tnt2.Hide();
                tnt3.Hide();

                gameover_shamshir();
                timer15.Stop();


            }
        }

        void bigenemi_ai_shot()
        {
            if (bigshotai == true)
            {
                if (sum > BIG)
                {
                    timer17.Stop();
                    player.Location = new Point(big.Location.X + 180, 500);
                    goolole();
                    shelick();
                }
            }
            if (big.Visible == false && bigshotai == true)
            {
                timer17.Start();
            }
        }

        void MoveCoins()
        {
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Tag == "Coin")
                {
                    if (c.Top > 450)
                    {
                        Random rnd = new Random();
                        x = rnd.Next(5, 690);
                        c.Location = new Point(x, -50);
                        c.Visible = false;
                        RandomCoin.Stop();
                    }
                    else
                    {
                        c.Visible = true;
                        c.Top += 10;
                    }
                }
            }
        }

        void GetCoins()
        {
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Tag == "Coin")
                {
                    if (c.Bounds.IntersectsWith(player.Bounds))
                    {
                        Random rnd = new Random();
                        x = rnd.Next(5, 690);
                        c.Location = new Point(x, -50);
                        RandomCoin.Stop();
                        sum++;
                        score.Text = sum + "";
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled == true)
            {

                if (e.KeyCode == Keys.Right)
                {
                    if (player.Left < 700)
                    {
                        player.Left += sj;
                    }
                    if (space == true)
                    {
                        shelik.SoundLocation = Environment.CurrentDirectory + @"\aspose_gun-gunshot-02.wav";
                        shelik.Play();
                        goolole();
                    }
                }
                if (e.KeyCode == Keys.Left)
                {
                    if (player.Left > 5)
                    {
                        player.Left -= sj;
                    }
                    if (space == true)
                    {
                        shelik.SoundLocation = Environment.CurrentDirectory + @"\aspose_gun-gunshot-02.wav";
                        shelik.Play();
                        goolole();
                    }
                }
                if (e.KeyCode == Keys.Space)
                {
                    space = true;
                    shelik.SoundLocation = Environment.CurrentDirectory + @"\aspose_gun-gunshot-02.wav";
                    shelik.Play();
                    goolole();
                }
                if (e.KeyCode == Keys.T)
                {
                    cheetcode.Show();
                }
                if (e.KeyCode == Keys.Enter)
                {
                    cheet = cheetcode.Text;
                    cheetcode.Text = "";
                    cheetcode.Hide();
                    if (cheet == "s6413d")
                    {
                        sj = 50;
                    }
                    else if (cheet == "r307176n")
                    {
                        sg = 80;
                    }
                    else if (cheet == "m3131")
                    {
                        GM = true;
                    }
                    else if (cheet == "AI")
                    {
                        AI.SoundLocation = Environment.CurrentDirectory + @"\Warp Portal Opening Stinger.wav";
                        AI.Play();
                        timer17.Start();
                        bigshotai = true;
                    }
                    else if (cheet == "NOAI")
                    {
                        timer17.Stop();
                        bigshotai = false;
                    }
                }
                if (e.KeyCode == Keys.J)
                {
                    sj = 60;
                    timer5.Start();
                }
                if (e.KeyCode == Keys.G)
                {
                    sg = 110;
                    timer8.Start();
                }

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled == true)
            {

                if (e.KeyCode == Keys.Right)
                {
                    if (player.Left < 700)
                    {
                        player.Left += sj;
                    }
                }
                if (e.KeyCode == Keys.Left)
                {
                    if (player.Left > 5)
                    {
                        player.Left -= sj;
                    }
                }
                if (e.KeyCode == Keys.Space)
                {
                    space = false;
                    goolole();
                }
                if (e.KeyCode == Keys.T)
                {
                    cheetcode.Show();
                }
                if (e.KeyCode == Keys.Enter)
                {
                    cheet = cheetcode.Text;
                    cheetcode.Text = "";
                    cheetcode.Hide();
                    if (cheet == "s2j")
                    {
                        sj = 30;
                    }
                    else if (cheet == "s3g")
                    {
                        sg = 60;
                    }
                    else if (cheet == "GM")
                    {
                        GM = true;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameover();
            shelick();
            bigenemi_ai_shot();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (contorol == true)
            {
                this.Controls.Remove(enfejar);
                contorol = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sum++;
            if (sum >= scor)
            {
                scor += 5;
                se++;
                Speed.SoundLocation = Environment.CurrentDirectory + @"\3230_Arm_Whoosh_www.motionlab.ir.wav";
                Speed.Play();
            }
            if (sum >= nl)
            {
                if (ni % 2 == 1)
                {
                    this.BackgroundImage = Properties.Resources.warped_space_chromebook_wallpaper;
                    //BackColor = Color.Cyan;
                    ni++;
                }
                else if (ni % 2 == 0)
                {
                    this.BackgroundImage = Properties.Resources.pngtree_3d_planets_in_space_wallpapers_for_mobile_picture_image_2670749;
                    //BackColor = Color.Navy;
                    ni++;

                }
                nl += 20;
            }
            score.Text = sum + "";

        }

        private void reastart_Click(object sender, EventArgs e)
        {
            Application.Restart();
            timer1.Enabled = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            se++;
            Speed.SoundLocation = Environment.CurrentDirectory + @"\3230_Arm_Whoosh_www.motionlab.ir.wav";
            Speed.Play();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            Randomheart();
            getheart();
            MoveCoins();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            timer6.Start();
            Random rnd = new Random();
            interval = rnd.Next(7000, 14000);
            timer7.Interval = interval;
        }

        private void s_Click(object sender, EventArgs e)
        {
            sev = true;
            best = File.ReadAllText(Environment.CurrentDirectory + @"\Bestscore.txt");
            BEST = Convert.ToInt32(best);
            if (sum > BEST)
            {
                File.Delete(Environment.CurrentDirectory + @"\Bestscore.txt");

                File.AppendAllText(Environment.CurrentDirectory + @"\Bestscore.txt", sum + "");

            }
        }

        private void seve_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sev == false)
            {
                best = File.ReadAllText(Environment.CurrentDirectory + @"\Bestscore.txt");
                BEST = Convert.ToInt32(best);
                if (sum > BEST)
                {
                    File.Delete(Environment.CurrentDirectory + @"\Bestscore.txt");

                    File.AppendAllText(Environment.CurrentDirectory + @"\Bestscore.txt", sum + "");

                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            sj = 15;
            timer5.Stop();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            sg = 20;
            timer8.Stop();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            harekatenemi();
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            bigenemi();
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            GM = false;
            timer11.Stop();
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            timer13.Start();
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            shemshir();
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            foreach (Control a in this.Controls)
            {
                if (a is PictureBox && a.Tag == "shamshir" || a.Tag == "shamshir2")
                {
                    a.Location = new Point(900, 800);
                }
            }
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            random_tnt();
        }

        private void timer16_Tick(object sender, EventArgs e)
        {
            timer15.Start();
            Random rnd = new Random();
            interval2 = rnd.Next(100, 150);
            timer16.Interval = interval2;
        }

        private void timer17_Tick(object sender, EventArgs e)
        {
                   se = 1;
            if (i == 1)
            {
                player.Location = new Point(locationai1, 469);
                goolole();
                shelick();
                i++;
            }
            if (i == 2)
            {
                player.Location = new Point(locationai2, 469);
                goolole();
                shelick();
                i++;

            }
            if (i == 3)
            {
                player.Location = new Point(locationai3, 469);
                goolole();
                shelick();
                i =1;

            }
            //if (chekai1 == true)
            //{
            //    chekai1 = false;
            //    i++;
            //}
            //else
            //{
            //    if (locationai1 < 350 && player.Left > 6)
            //    {
            //        player.Left -= 110;
            //    }
            //    if (locationai1 > 350 && player.Left < 705)
            //    {
            //        player.Left += 110;
            //    }
            //    if (enemi1.Top > 475)
            //    {

            //        i++;
            //    }

            //goolole();
            //shelick();

            //else if (i == 2)
            //{
            //    if (chekai2 == true)
            //    {
            //        chekai2 = false;
            //        i++;
            //    }
            //    else
            //    {
            //        if (locationai2 < 350 && player.Left > 6)
            //        {
            //            player.Left -= 110;
            //        }
            //        if (locationai2 > 350 && player.Left < 705)
            //        {
            //            player.Left += 110;
            //        }
            //        if (enemi2.Top > 475)
            //        {

            //            i++;
            //        }
            //    }
            //    goolole();
            //    shelick();
            //}
            //else if (i == 3)
            //{
            //    if (chekai3 == true)
            //    {
            //        chekai3 = false;
            //        i = 1;
            //    }
            //    else
            //    {
            //        if (locationai3 < 350 && player.Left > 6)
            //        {
            //            player.Left -= 110;
            //        }
            //        if (locationai3 > 350 && player.Left < 705)
            //        {
            //            player.Left += 110;
            //        }
            //        if (enemi3.Top > 475)
            //        {

            //            i = 1;
            //        }
            //    }
            //    goolole();
            //    shelick();
            //}
        }
        //    if (enemi2.Top > enemi1.Top && enemi2.Top > enemi3.Top)
        //    {




        //            if (chekai2 == true)
        //            {
        //                chekai2 = false;
        //                i++;
        //            }
        //            else
        //            {
        //                if (locationai2 < 350 && player.Left > 6)
        //                {
        //                    player.Left -= 110;
        //                }
        //                if (locationai2 > 350 && player.Left < 705)
        //                {
        //                    player.Left += 110;
        //                }
        //                if (enemi2.Top > 475)
        //                {

        //                    i++;
        //                }
        //            }
        //            goolole();
        //            shelick();


        //    }
        //    if (enemi3.Top > enemi1.Top && enemi3.Top > enemi2.Top)
        //    {



        //            if (chekai3 == true)
        //            {
        //                chekai3 = false;
        //                i = 1;
        //            }
        //            else
        //            {
        //                if (locationai3 < 350 && player.Left > 6)
        //                {
        //                    player.Left -= 110;
        //                }
        //                if (locationai3 > 350 && player.Left < 705)
        //                {
        //                    player.Left += 110;
        //                }
        //                if (enemi3.Top > 475)
        //                {

        //                    i = 1;
        //                }
        //            }
        //            goolole();
        //            shelick();

        //    }
        //}

        private void RandomCoin_Tick(object sender, EventArgs e)
        {
            MoveCoins();
            GetCoins();
        }

        private void timer18_Tick(object sender, EventArgs e)
        {
            RandomCoin.Start();
            Random rnd = new Random();
            interval2 = rnd.Next(100, 150);
            timer18.Interval = interval2;
        }
    }
}
