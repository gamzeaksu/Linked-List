using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapýlarý_Ödev_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num;
        string isim;
        double ort;
        Node head;
        private void BtnEkle_Click(object sender, EventArgs e)
        {  
            if(txtNumara.Text=="")
            {
                MessageBox.Show("Lütfen öðrencinin numarasýný giriniz.");
                
                return;
            }
            if (txtAdSoyad.Text == "")
            {
                MessageBox.Show("Lütfen öðrencinin adýný giriniz.");
                txtAdSoyad.Clear();
                return;
            }
            if (txtOrtalama.Text=="")
            {
                MessageBox.Show("Lütfen öðrencinin ortalamasýný giriniz.");
                
                return;
            }
            ErrorProvider provider = new ErrorProvider();
            bool sayý = SayiMi(txtNumara.Text);
            bool sayý2 = SayiMi(txtOrtalama.Text);
            if (sayý)
                num =Convert.ToInt32(txtNumara.Text);
            else
            {
                provider.SetError(txtNumara,"Lütfen sayý giriniz.");
                txtNumara.Clear();
                return;
            }
            isim = txtAdSoyad.Text;
            if(sayý2)
                ort = Convert.ToDouble(txtOrtalama.Text);
            else
            {
                provider.SetError(txtOrtalama, "Lütfen sayý giriniz.");
                txtOrtalama.Clear();
                return;
            }         
            if (rbBasa.Checked)
            {
                basaEkle(num,isim,ort);
                printList();
            }
            else if(rbSýraya.Checked)
            {
               sonaEkle(num, isim, ort);
               sýralaOrt();
                printList();
            }
            else
            {
                sonaEkle(num,isim,ort);
                printList();
            }
            listeBoþMu();
        }
        void basaEkle(int numara, string isim,double ortalama)//okey
        {
            Node yeni = new Node(numara, isim,ortalama);
            if (yeni.ort >= 100 || yeni.ort <= 0)
            {
                MessageBox.Show("Sýnav ortalamasý 100'den büyük 0'dan küçük olamaz.");
                txtOrtalama.Clear();
                return;
            }
            if (head == null)
            {
                yeni.sonraki = head;
                head = yeni;
                return;
            }
            if(head.num==numara)
            {
                MessageBox.Show("Ayný numarada baþka bir öðrenci olamaz");
                txtNumara.Clear();
                return;
            }
            yeni.sonraki = head;
            head = yeni;
        }
        void printList()//okey
        {
            listBoxSýralý.Items.Clear();
            Node tnode = head;
            while (tnode != null)
            {
                listBoxSýralý.Items.Add(tnode.num + tnode.isim + tnode.ort);
                tnode = tnode.sonraki;
            }
        }
        void sonaEkle(int num, string isim, double ort)//okey
        {
            Node yeni = new Node(num, isim, ort);
            if (yeni.ort >= 100 || yeni.ort <= 0)
            {
                MessageBox.Show("Sýnav ortalamasý 100'den büyük 0'dan küçük olamaz.");
                txtOrtalama.Clear();
                return;
            }
            if (head == null)
            {
                head = yeni;
                return;
            }
            yeni.sonraki = null;
            Node son = head;
            while (son.sonraki != null)
                son = son.sonraki;
            if (son.num == yeni.num)
            {
                MessageBox.Show("Ayný numarada baþka bir öðrenci olamaz");
                txtNumara.Clear();
                return;
            }

            son.sonraki = yeni;
            return;
        }
        int listeBoyu()//okey//
        {
            int n = 0;
            Node aktif = head;
            if(aktif==null)
            {
                return n;
            }
            while (aktif.sonraki != null)
            {
                aktif = aktif.sonraki;
                n++;
            }
            return n+1 ;
        }
        double[] diziyeAktarmaOrt(int i)//okey
        {
            Node current = head;
            double[] dizi = new double[i];
            for (int l = 0; l < dizi.Length; l++)
            {
                dizi[l] = current.ort;
                current = current.sonraki;
            }
            return dizi;
        }
        void sýralaOrt()//okey
        {
            int listeBoyutu = listeBoyu();
            double[] dizi = diziyeAktarmaOrt(listeBoyutu);
            int[] numara = diziyeAktarmaNo();
            string[] isim = diziyeAktarmaIsim();
            for (int i = 1; i < listeBoyutu; i++)
            {
                for (int j = 0; j < listeBoyutu-1; j++)
                {
                    if (dizi[j] > dizi[j + 1])
                    {
                        double gecici = dizi[j + 1];
                        int geçici1 = numara[j + 1];
                        string geçici2 = isim[j + 1];
                        dizi[j + 1] = dizi[j];
                        numara[j + 1] = numara[j];
                        isim[j + 1] = isim[j];
                        dizi[j] = gecici;
                        numara[j] = geçici1;
                        isim[j] = geçici2;
                    }
                }
            }
            Node current =head;
            for (int f = 0; f < listeBoyutu; f++)
            {
                current.ort = dizi[f];
                current.isim = isim[f];
                current.num = numara[f];
                current = current.sonraki;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listeBoþMu();
        }
        private void BtnListeBoyu_Click(object sender, EventArgs e)
        {
            
           lblListeBoyu.Text=""+ listeBoyu()+"";
        }
        int[] diziyeAktarmaNo()
        {
            Node current =head;
            int[] dizi = new int[listeBoyu()];
            for (int l = 0; l < dizi.Length; l++)
            {
                dizi[l] = current.num;
                current = current.sonraki;
            }
            return dizi;
        }
        string[] diziyeAktarmaIsim()
        {
            Node current = head;
            string[] dizi = new string[listeBoyu()];
            for (int l = 0; l < dizi.Length; l++)
            {
                dizi[l] = current.isim;
                current = current.sonraki;
            }
            return dizi;
        }
        Node[] diziyeAktarma()
        {
            int i = listeBoyu();
            Node[]dizi = new Node[i];
            Node current = head;
            
            for (int l = 0; l < dizi.Length; l++)
            {
                
                dizi[l] = current;
                current = current.sonraki;
            }
            return dizi;
        }
        void isimSýrala()
        {
            Node[] dizi = diziyeAktarma();
            string[] isim = diziyeAktarmaIsim();
            Array.Sort(isim);
            Node temp;
            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = 0; j < dizi.Length; j++)
                {
                    if (dizi[i].isim == isim[j])
                    {
                        temp = dizi[j];
                        dizi[j] = dizi[i];
                        dizi[i] = temp;
                    }
                }
            }
            listBoxSýralý.Items.Clear();
            for (int i = 0; i < dizi.Length; i++)
            {
                listBoxSýralý.Items.Add(dizi[i].num + dizi[i].isim + dizi[i].ort);
            }
        }
        void numSýrala()
        {
            int listeBoyutu = listeBoyu();
            double[] dizi = diziyeAktarmaOrt(listeBoyutu);
            int[] numara = diziyeAktarmaNo();
            string[] isim = diziyeAktarmaIsim();
            for (int i = 1; i < listeBoyutu; i++)
            {
                for (int j = 0; j < listeBoyutu - 1; j++)
                {
                    if (numara[j] > numara[j + 1])
                    {
                        double gecici = dizi[j + 1];
                        int geçici1 = numara[j + 1];
                        string geçici2 = isim[j + 1];
                        dizi[j + 1] = dizi[j];
                        numara[j + 1] = numara[j];
                        isim[j + 1] = isim[j];
                        dizi[j] = gecici;
                        numara[j] = geçici1;
                        isim[j] = geçici2;
                    }
                }
            }
            Node current = head;
            for (int f = 0; f < listeBoyutu; f++)
            {
                current.ort = dizi[f];
                current.isim = isim[f];
                current.num = numara[f];
                current = current.sonraki;
            }
        }
        private void BtnSilme_Click(object sender, EventArgs e)
        {
            if(rbBastakini.Checked)
            {
                bastakiniSil();
                printList();
            }
            else if(rbGirilenSýrayý.Checked)
            {
                int sýra = Convert.ToInt32(txtSýra.Text); 
                girilenSýrayýSil(sýra);
                printList();
            }
            else if(rbGirilenNumarayý.Checked)
            {
                int numara = Convert.ToInt32(txtSýra.Text);
                girilenNoSil(numara);
                printList();
            }
            else if(rbSondakini.Checked)
            {
                sondakiniSil();
                printList();
            }
            else//tümünü sil
            {
                head = null;
                printList();
            }
            listeBoþMu();
        }
        void bastakiniSil()
        {
            if (head == null)
            {
                MessageBox.Show("liste boþ");
                return;
            }
            head = head.sonraki;
        }
        void sondakiniSil()
        {
            Node current = head;
            Node önceki = null;
            if(current==null)
            {
                MessageBox.Show("Liste Boþ.");
                return;
            }
            if( head.sonraki == null)
            {
                head = null;
                return;
            }
            while (current.sonraki!=null)
            {
                önceki = current;
                current = current.sonraki;
            }
            önceki.sonraki = null;
        }
        void girilenSýrayýSil(int sýra)
        {
            if (head == null)
            {
                MessageBox.Show("Liste boþ");
                return;
            }
            Node temp = head;

            if (sýra == 0)
            {
                head = temp.sonraki;
                return;
            }
            for (int i = 0; temp != null && i < sýra - 1; i++)
                temp = temp.sonraki;

            if (temp == null || temp.sonraki == null)
            {
                MessageBox.Show("Girdiðiniz sýra öðrencilerden fazla.");
                txtSýra.Clear();
                return;
            }
            Node sonraki = temp.sonraki.sonraki;
            temp.sonraki = sonraki;
        }
        void girilenNoSil(int numara)
        {
            Node temp = head;
            Node önceki = null;
            if (temp != null && temp.num == numara)
            {
                head = temp.sonraki; 
                return;
            }
            while (temp != null && temp.num != numara)
            {
                önceki = temp;
                temp = temp.sonraki;
            }
            if (temp == null)
            {
                MessageBox.Show("Girdiðiniz numarada bir öðrenci yok.");
                txtSýra.Clear();
                return;
            }
            önceki.sonraki=temp.sonraki;
        }
        private void BtnListele_Click_1(object sender, EventArgs e)
        {
            if (rbOrtalamayaGöre.Checked)
            {
                sýralaOrt();
                printList();
            }
            else if (rbAdaGöre.Checked)
            {
                isimSýrala();
            }
            else
            {
                numSýrala();
                printList();
            }
        }

        private void Button1_Click(object sender, EventArgs e)//listeBoþ
        {
        }
        void listeBoþMu()
        {
            if (head == null)
            {
                btnListeBos.BackColor = Color.Red;
                btnListeBos.ForeColor = Color.White;
                btnListeBos.Text = "LÝSTE BOÞ";
            }
            else
            {
                btnListeBos.ForeColor = Color.White;
                btnListeBos.BackColor = Color.YellowGreen;
                btnListeBos.Text = "LÝSTE DOLU";
            }
        }
        private void TxtNumara_TextChanged(object sender, EventArgs e)
        {
            
        }
        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr))
                    return false;
            }
            return true;
        }  
    }
}
