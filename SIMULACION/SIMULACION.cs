using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SIMULACION
{
    public partial class SIMULACION : Form
    {
        public SIMULACION()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void back_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            this.Hide();
            m.Show();
        }


        private void SIMULACION_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pizarron_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics papel = pizarron.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            Pen marcador = new Pen(Color.Red);
            SolidBrush brocha = new SolidBrush(Color.Blue);
            SolidBrush marca = new SolidBrush(Color.Green);
            Font letra = new Font("Arial", 10);


            //LIMITES DE ESTRUCTURAS

            // Egobierno
            papel.DrawRectangle(lapiz, 100,198 , 70, 70);
            papel.DrawRectangle(lapiz, 170, 198, 70, 70);

            // Edificio 2 y 4 P1
            papel.DrawRectangle(lapiz, 170, 10, 200, 50);
            papel.DrawRectangle(lapiz, 370, 10, 200, 50);

            //Edificio 2 y 4 PB
            papel.DrawRectangle(lapiz, 170, 60, 200, 50);
            papel.DrawRectangle(lapiz, 370, 60, 200, 50);

            //Edificio 1 y 3 PB
            papel.DrawRectangle(lapiz, 170, 350, 200, 50);
            papel.DrawRectangle(lapiz, 370, 350, 200, 50);

            //Edificio 1 y 3 P1
            papel.DrawRectangle(lapiz, 170, 400, 200, 50);
            papel.DrawRectangle(lapiz, 370, 400, 200, 50);

            // Laboratorios
            papel.DrawRectangle(lapiz, 500, 198, 70, 70);
            papel.DrawRectangle(lapiz, 570, 198, 70, 70);

            //Cafeteria
            papel.DrawRectangle(lapiz, 640, 400, 70, 70);


            //NODOS

            //Edificios 2 y 4 P1
            papel.FillEllipse(brocha, 220, 15, 40, 40);
            papel.FillEllipse(brocha, 480, 15, 40, 40);

            //Edificios 2 y 4 PB
            papel.FillEllipse(brocha, 280, 65, 40, 40);
            papel.FillEllipse(brocha, 420, 65, 40, 40);

            //Egobierno
            papel.FillEllipse(brocha, 110, 200, 40, 40);
            papel.FillEllipse(brocha, 190, 225, 40, 40);

            //Edificios 1 y 3 PB
            papel.FillEllipse(brocha, 280, 355, 40, 40);
            papel.FillEllipse(brocha, 420, 355, 40, 40);

            //Edificios 1 y 3 P1
            papel.FillEllipse(brocha, 220, 405, 40, 40);
            papel.FillEllipse(brocha, 480, 405, 40, 40);

            //Laboratorios
            papel.FillEllipse(brocha, 510, 200, 40, 40);
            papel.FillEllipse(brocha, 580, 225, 40, 40);

            //Cafeteria
            papel.FillEllipse(brocha, 655, 415, 40, 40);

            //Zonas seguras
            papel.FillEllipse(marca, 5, 198, 70, 70);
            papel.FillEllipse(marca, 335, 198, 70, 70);
            papel.FillEllipse(marca, 680, 198, 70, 70);




            //ADYACENCIAS 

            // A y B
            papel.DrawLine(marcador, 240, 28, 500, 28);

            // A Y C
            papel.DrawLine(marcador, 240, 28, 300, 81);

            // A Y E
            papel.DrawLine(marcador, 130, 215, 240, 28);
            
            // B Y D
            papel.DrawLine(marcador, 500, 28, 440, 81);

            // B Y H
            papel.DrawLine(marcador, 500, 28,600 ,245 );

            // C Y D
            papel.DrawLine(marcador, 300, 81, 440, 81);

            // C Y Z2
            papel.DrawLine(marcador, 300, 81,370 ,238 );

            // C Y F
            papel.DrawLine(marcador, 300, 81, 210, 250);

            // C Y Z1
            papel.DrawLine(marcador, 300, 81, 35, 238);

            // D Y Z2
            papel.DrawLine(marcador, 440, 81, 370,238 );

            // D Y G
            papel.DrawLine(marcador, 440, 81, 530,220 );

            // D Y Z3
            papel.DrawLine(marcador, 440, 81, 715, 225);

            // E Y F
            papel.DrawLine(marcador, 130, 215, 210, 250);

            // E Y K
            papel.DrawLine(marcador, 130, 215,240 ,425 );

            // F Y Z2
            papel.DrawLine(marcador, 210, 250,370 ,238 );

            // F Y Z1
            papel.DrawLine(marcador, 210, 250, 35, 238);

            // F Y I
            papel.DrawLine(marcador, 210, 250, 300, 375);

            // G Y Z2
            papel.DrawLine(marcador, 530, 220, 370, 238);

            // G Y Z3
            papel.DrawLine(marcador, 530, 220, 715, 225);

            // G Y H
            papel.DrawLine(marcador, 530, 220, 600, 245);

            // H Y L 
            papel.DrawLine(marcador, 600, 245,500 ,425 );

            // I Y Z2
            papel.DrawLine(marcador, 300, 375,370 ,238 );

            // I Y Z1
            papel.DrawLine(marcador, 300, 375, 35, 238);

            // I Y J
            papel.DrawLine(marcador, 300, 375, 440,375 );

            // I Y K
            papel.DrawLine(marcador, 300, 375, 240, 425);

            // J Y I
            papel.DrawLine(marcador,440 , 375, 300, 375);

            // J Y Z2
            papel.DrawLine(marcador, 440, 375, 370, 238);

            // J Y G
            papel.DrawLine(marcador, 440, 375, 530, 220);

            // J Y L
            papel.DrawLine(marcador, 440, 375, 500, 425);

            // J Y Z3
            papel.DrawLine(marcador, 440, 375, 715, 225);

            // J Y M
            papel.DrawLine(marcador, 440, 375, 675, 435);

            // K Y L
            papel.DrawLine(marcador, 240, 425, 500, 425);

            // M Y Z3
            papel.DrawLine(marcador, 675, 435,715 ,225 );

            //NOMBRAMIENTO DE LOS NODOS

            //A
            papel.DrawString("A", letra, Brushes.Black, 225, 20);
            //B
            papel.DrawString("B", letra, Brushes.Black, 485, 20);
            //C
            papel.DrawString("C", letra, Brushes.Black, 285,75);
            //D
            papel.DrawString("D", letra, Brushes.Black, 425, 75);
            //E
            papel.DrawString("E", letra, Brushes.Black, 115,205);
            //F
            papel.DrawString("F", letra, Brushes.Black, 200,230);
            //G
            papel.DrawString("G", letra, Brushes.Black,525 ,203);
            //H
            papel.DrawString("H", letra, Brushes.Black, 600,235);
            //I
            papel.DrawString("I", letra, Brushes.Black, 300, 375);
            //J
            papel.DrawString("J", letra, Brushes.Black, 430,375);
            //K
            papel.DrawString("K", letra, Brushes.Black, 225,420);
            //L
            papel.DrawString("L", letra, Brushes.Black, 500, 425);
            //M
            papel.DrawString("M", letra, Brushes.Black, 670, 435);
            //Z1
            papel.DrawString("Z1", letra, Brushes.Black, 20, 220);
            //Z2
            papel.DrawString("Z2", letra, Brushes.Black, 345, 220);
            //Z3
            papel.DrawString("Z3", letra, Brushes.Black, 715, 220);



        }

        private void button2_Click(object sender, EventArgs e)
        {

            Graphics papel = pizarron.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            Pen marcador = new Pen(Color.Red);
            Pen follow = new Pen(Color.Lime);
            SolidBrush brocha = new SolidBrush(Color.Blue);
            SolidBrush marca = new SolidBrush(Color.Green);
            Font letra = new Font("Arial", 10);
            Font l1 = new Font("Arial", 8);

            //LIMITES DE ESTRUCTURAS

            // Egobierno
            papel.DrawRectangle(lapiz, 100, 198, 70, 70);
            papel.DrawRectangle(lapiz, 170, 198, 70, 70);

            // Edificio 2 y 4 P1
            papel.DrawRectangle(lapiz, 170, 10, 200, 50);
            papel.DrawRectangle(lapiz, 370, 10, 200, 50);

            //Edificio 2 y 4 PB
            papel.DrawRectangle(lapiz, 170, 60, 200, 50);
            papel.DrawRectangle(lapiz, 370, 60, 200, 50);

            //Edificio 1 y 3 PB
            papel.DrawRectangle(lapiz, 170, 350, 200, 50);
            papel.DrawRectangle(lapiz, 370, 350, 200, 50);

            //Edificio 1 y 3 P1
            papel.DrawRectangle(lapiz, 170, 400, 200, 50);
            papel.DrawRectangle(lapiz, 370, 400, 200, 50);

            // Laboratorios
            papel.DrawRectangle(lapiz, 500, 198, 70, 70);
            papel.DrawRectangle(lapiz, 570, 198, 70, 70);

            //Cafeteria
            papel.DrawRectangle(lapiz, 640, 400, 70, 70);


            //NODOS

            //Edificios 2 y 4 P1
            papel.FillEllipse(brocha, 220, 15, 40, 40);
            papel.FillEllipse(brocha, 480, 15, 40, 40);

            //Edificios 2 y 4 PB
            papel.FillEllipse(brocha, 280, 65, 40, 40);
            papel.FillEllipse(brocha, 420, 65, 40, 40);

            //Egobierno
            papel.FillEllipse(brocha, 110, 200, 40, 40);
            papel.FillEllipse(brocha, 190, 225, 40, 40);

            //Edificios 1 y 3 PB
            papel.FillEllipse(brocha, 280, 355, 40, 40);
            papel.FillEllipse(brocha, 420, 355, 40, 40);

            //Edificios 1 y 3 P1
            papel.FillEllipse(brocha, 220, 405, 40, 40);
            papel.FillEllipse(brocha, 480, 405, 40, 40);

            //Laboratorios
            papel.FillEllipse(brocha, 510, 200, 40, 40);
            papel.FillEllipse(brocha, 580, 225, 40, 40);

            //Cafeteria
            papel.FillEllipse(brocha, 655, 415, 40, 40);

            //Zonas seguras
            papel.FillEllipse(marca, 5, 198, 70, 70);
            papel.FillEllipse(marca, 335, 198, 70, 70);
            papel.FillEllipse(marca, 680, 198, 70, 70);




            //ADYACENCIAS 

            // A y B
            papel.DrawLine(marcador, 240, 28, 500, 28);

            // A Y C
            papel.DrawLine(marcador, 240, 28, 300, 81);

            // A Y E
            papel.DrawLine(marcador, 130, 215, 240, 28);

            // B Y D
            papel.DrawLine(marcador, 500, 28, 440, 81);

            // B Y H
            papel.DrawLine(marcador, 500, 28, 600, 245);

            // C Y D
            papel.DrawLine(marcador, 300, 81, 440, 81);

            // C Y Z2
            papel.DrawLine(marcador, 300, 81, 370, 238);

            // C Y F
            papel.DrawLine(marcador, 300, 81, 210, 250);

            // C Y Z1
            papel.DrawLine(marcador, 300, 81, 35, 238);

            // D Y Z2
            papel.DrawLine(marcador, 440, 81, 370, 238);

            // D Y G
            papel.DrawLine(marcador, 440, 81, 530, 220);

            // D Y Z3
            papel.DrawLine(marcador, 440, 81, 715, 225);

            // E Y F
            papel.DrawLine(marcador, 130, 215, 210, 250);

            // E Y K
            papel.DrawLine(marcador, 130, 215, 240, 425);

            // F Y Z2
            papel.DrawLine(marcador, 210, 250, 370, 238);

            // F Y Z1
            papel.DrawLine(marcador, 210, 250, 35, 238);

            // F Y I
            papel.DrawLine(marcador, 210, 250, 300, 375);

            // G Y Z2
            papel.DrawLine(marcador, 530, 220, 370, 238);

            // G Y Z3
            papel.DrawLine(marcador, 530, 220, 715, 225);

            // G Y H
            papel.DrawLine(marcador, 530, 220, 600, 245);

            // H Y L 
            papel.DrawLine(marcador, 600, 245, 500, 425);

            // I Y Z2
            papel.DrawLine(marcador, 300, 375, 370, 238);

            // I Y Z1
            papel.DrawLine(marcador, 300, 375, 35, 238);

            // I Y J
            papel.DrawLine(marcador, 300, 375, 440, 375);

            // I Y K
            papel.DrawLine(marcador, 300, 375, 240, 425);

            // J Y I
            papel.DrawLine(marcador, 440, 375, 300, 375);

            // J Y Z2
            papel.DrawLine(marcador, 440, 375, 370, 238);

            // J Y G
            papel.DrawLine(marcador, 440, 375, 530, 220);

            // J Y L
            papel.DrawLine(marcador, 440, 375, 500, 425);

            // J Y Z3
            papel.DrawLine(marcador, 440, 375, 715, 225);

            // J Y M
            papel.DrawLine(marcador, 440, 375, 675, 435);

            // K Y L
            papel.DrawLine(marcador, 240, 425, 500, 425);

            // M Y Z3
            papel.DrawLine(marcador, 675, 435, 715, 225);

            //NOMBRAMIENTO DE LOS NODOS

            //A
            papel.DrawString("A", letra, Brushes.Black, 225, 20);
            //B
            papel.DrawString("B", letra, Brushes.Black, 485, 20);
            //C
            papel.DrawString("C", letra, Brushes.Black, 285, 75);
            //D
            papel.DrawString("D", letra, Brushes.Black, 425, 75);
            //E
            papel.DrawString("E", letra, Brushes.Black, 115, 205);
            //F
            papel.DrawString("F", letra, Brushes.Black, 200, 230);
            //G
            papel.DrawString("G", letra, Brushes.Black, 525, 203);
            //H
            papel.DrawString("H", letra, Brushes.Black, 600, 235);
            //I
            papel.DrawString("I", letra, Brushes.Black, 300, 375);
            //J
            papel.DrawString("J", letra, Brushes.Black, 430, 375);
            //K
            papel.DrawString("K", letra, Brushes.Black, 225, 420);
            //L
            papel.DrawString("L", letra, Brushes.Black, 500, 425);
            //M
            papel.DrawString("M", letra, Brushes.Black, 670, 435);
            //Z1
            papel.DrawString("Z1", letra, Brushes.Black, 20, 220);
            //Z2
            papel.DrawString("Z2", letra, Brushes.Black, 345, 220);
            //Z3
            papel.DrawString("Z3", letra, Brushes.Black, 715, 220);

            Nodo A = new Nodo(240, 28, "A");
            Nodo B = new Nodo(500, 28, "B");
            Nodo C = new Nodo(300, 81, "C"); 
            Nodo D = new Nodo(440, 81, "D");
            Nodo E = new Nodo(130, 215,"E");
            Nodo F = new Nodo(210, 250, "F");
            Nodo G = new Nodo(530, 220, "G");
            Nodo H = new Nodo(600, 245, "H");
            Nodo I = new Nodo(300,375 , "I");
            Nodo J = new Nodo(440,375 , "J");
            Nodo K = new Nodo(240, 425, "K");
            Nodo L = new Nodo(500, 425, "L");
            Nodo M = new Nodo(675,435 , "M");
            Nodo Z1 = new Nodo(35, 238, "Z1");
            Nodo Z2 = new Nodo(370, 238, "Z2");
            Nodo Z3 = new Nodo(715, 225, "Z3");

            // Crear aristas con un numero aleatorio 
            Random rand = new Random();
            int n1 = rand.Next(0, 100);
            A.AddEdge(new adyacencias(A, B, n1));
            string num = n1.ToString();
            papel.DrawString(num, l1, Brushes.Black, 355, 15);

            int n2 = rand.Next(0, 100);
            A.AddEdge(new adyacencias(A, C, n2));
            string num2 = n2.ToString();
            papel.DrawString(num2, l1, Brushes.Black, 275, 45);

            int n3 = rand.Next(0, 100);
            A.AddEdge(new adyacencias(A, E, n3));
            string num3 = n3.ToString();
            papel.DrawString(num3, l1, Brushes.Black, 160, 120);

            int n4 = rand.Next(0, 100);
            B.AddEdge(new adyacencias(B, D, n4));
            string num4 = n4.ToString();
            papel.DrawString(num4, l1, Brushes.Black, 455, 40);

            int n5 = rand.Next(0, 100);
            B.AddEdge(new adyacencias(B, H, n5));
            string num5 = n5.ToString();
            papel.DrawString(num5, l1, Brushes.Black, 540, 95);

            int n6 = rand.Next(0, 100);
            C.AddEdge(new adyacencias(C, D, n6));
            string num6 = n6.ToString();
            papel.DrawString(num6, l1, Brushes.Black, 355, 65);

            int n7 = rand.Next(0, 100);
            C.AddEdge(new adyacencias(C, Z2, n7));
            string num7 = n7.ToString();
            papel.DrawString(num7, l1, Brushes.Black, 315, 150);

            int n8 = rand.Next(0, 100);
            C.AddEdge(new adyacencias(C, F, n8));
            string num8 = n8.ToString();
            papel.DrawString(num8, l1, Brushes.Black, 230, 170);

            int n9 = rand.Next(0, 100);
            C.AddEdge(new adyacencias(C, Z1, n9));
            string num9 = n9.ToString();
            papel.DrawString(num9, l1, Brushes.Black, 180, 150);

            int n10 = rand.Next(0, 100);
            D.AddEdge(new adyacencias(D,Z2 , n10));
            string num10 = n10.ToString();
            papel.DrawString(num10, l1, Brushes.Black, 410,150);

            int n11 = rand.Next(0, 100);
            D.AddEdge(new adyacencias(D, G, n11));
            string num11 = n11.ToString();
            papel.DrawString(num11, l1, Brushes.Black, 485, 140);

            int n12 = rand.Next(0, 100);
            D.AddEdge(new adyacencias(D, Z3, n12));
            string num12 = n12.ToString();
            papel.DrawString(num12, l1, Brushes.Black, 600,150);

            int n13 = rand.Next(0, 100);
            E.AddEdge(new adyacencias(E, F, n13));
            string num13 = n13.ToString();
            papel.DrawString(num13, l1, Brushes.Black, 170, 220);

            int n14 = rand.Next(0, 100);
            E.AddEdge(new adyacencias(E, K, n14));
            string num14 = n14.ToString();
            papel.DrawString(num14, l1, Brushes.Black,200 ,380);

            int n15 = rand.Next(0, 100);
            F.AddEdge(new adyacencias(F, Z1, n15));
            string num15 = n15.ToString();
            papel.DrawString(num15, l1, Brushes.Black, 110,245 );

            int n16 = rand.Next(0, 100);
            F.AddEdge(new adyacencias(F, Z2, n16));
            string num16 = n16.ToString();
            papel.DrawString(num16, l1, Brushes.Black, 290, 245);

            int n17 = rand.Next(0, 100);
            F.AddEdge(new adyacencias(F, I, n17));
            string num17 = n17.ToString();
            papel.DrawString(num17, l1, Brushes.Black, 225, 290);

            int n18 = rand.Next(0, 100);
            G.AddEdge(new adyacencias(G, Z2, n18));
            string num18 = n18.ToString();
            papel.DrawString(num18, l1, Brushes.Black, 440,230);

            int n19 = rand.Next(0, 100);
            G.AddEdge(new adyacencias(G, Z3, n19));
            string num19 = n19.ToString();
            papel.DrawString(num19, l1, Brushes.Black, 620, 205);

            int n20 = rand.Next(0, 100);
            G.AddEdge(new adyacencias(G, H, n20));
            string num20 = n20.ToString();
            papel.DrawString(num20, l1, Brushes.Black, 555, 235);

            int n21 = rand.Next(0, 100);
            G.AddEdge(new adyacencias(G, J, n21));
            string num21 = n21.ToString();
            papel.DrawString(num21, l1, Brushes.Black, 460, 300);

            int n22 = rand.Next(0, 100);
            H.AddEdge(new adyacencias(H, L, n22));
            H.AddEdge(new adyacencias(H, G ,n20));
            string num22 = n22.ToString();
            papel.DrawString(num22, l1, Brushes.Black, 515, 360);

            int n23 = rand.Next(0, 100);
            I.AddEdge(new adyacencias(I, Z2, n23));
            string num23 = n23.ToString();
            papel.DrawString(num23, l1, Brushes.Black, 320, 300);

            int n24 = rand.Next(0, 100);
            I.AddEdge(new adyacencias(I, Z1, n24));
            string num24 = n24.ToString();
            papel.DrawString(num24, l1, Brushes.Black, 145, 300);

            int n25 = rand.Next(0, 100);
            I.AddEdge(new adyacencias(I, J, n25));
            string num25 = n25.ToString();
            papel.DrawString(num25, l1, Brushes.Black, 355, 360);

            int n26 = rand.Next(0, 100);
            I.AddEdge(new adyacencias(I, K, n26));
            string num26 = n26.ToString();
            papel.DrawString(num26, l1, Brushes.Black, 255, 390);

            int n27 = rand.Next(0, 100);
            J.AddEdge(new adyacencias(J, Z2, n27));
            string num27 = n27.ToString();
            papel.DrawString(num27, l1, Brushes.Black, 390, 300);

            int n28 = rand.Next(0, 100);
            J.AddEdge(new adyacencias(J, Z3, n28));
            string num28 = n28.ToString();
            papel.DrawString(num28, l1, Brushes.Black, 605, 285);

            int n29 = rand.Next(0, 100);
            J.AddEdge(new adyacencias(J, M, n29));
            string num29 = n29.ToString();
            papel.DrawString(num29, l1, Brushes.Black, 590, 415);

            int n30 = rand.Next(0, 100);
            J.AddEdge(new adyacencias(J, L, n30));
            L.AddEdge(new adyacencias(L, J, n30));
            string num30 = n30.ToString();
            papel.DrawString(num30, l1, Brushes.Black, 450, 400);

            int n31 = rand.Next(0, 100);
            K.AddEdge(new adyacencias(K, L, n31));
            K.AddEdge(new adyacencias(K, I, n26));
            string num31 = n31.ToString();
            papel.DrawString(num31, l1, Brushes.Black, 355, 425);

            int n32 = rand.Next(0, 100);
            M.AddEdge(new adyacencias(M, Z3, n32));
            M.AddEdge(new adyacencias(M, J, n29));
            string num32 = n32.ToString();
            papel.DrawString(num32, l1, Brushes.Black, 695, 335);


            // Crear el grafo y agregar los nodos
            Grafo grafo = new Grafo();
            grafo.AddNode(A);
            grafo.AddNode(B);
            grafo.AddNode(C);
            grafo.AddNode(D);
            grafo.AddNode(E);
            grafo.AddNode(F);
            grafo.AddNode(G);
            grafo.AddNode(H);
            grafo.AddNode(I);
            grafo.AddNode(J);
            grafo.AddNode(K);
            grafo.AddNode(L);
            grafo.AddNode(M);
            grafo.AddNode(Z1);
            grafo.AddNode(Z2);
            grafo.AddNode(Z3);


            string punto = textBox1.Text; ;
            punto = punto.ToUpper();

            //Hacemos uso del algoritmo
            List<Nodo> destinos = new List<Nodo>() { Z1, Z2, Z3 };
            Dictionary<Nodo, int> rutaMasCorta = grafo.Dijkstra((grafo.Buscar(punto)), destinos);

            Nodo[] path = rutaMasCorta.Keys.ToArray();

            for (int i = 0; i < (path.Length - 1 ); i++)
            {
                Nodo n = path[i];

                int x1 = n.x;
                int y1 = n.y;

                Nodo aux = path[i + 1];

                int x2 = aux.x;
                int y2 = aux.y;

                papel.DrawLine(follow, x1, y1, x2, y2);
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
