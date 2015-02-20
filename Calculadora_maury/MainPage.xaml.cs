using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Calculadora_maury
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            PageTitle.Text = "0";
        }

        float numero1 = (float)0.0;
        float resultado;
        int pant = 0;
        int temp = 0;
        int op = 0;
        int enable;
        
        
        


        private void Escribir(object sender, RoutedEventArgs e)
        {
            enable=0;
            Button boton = sender as Button;

            

            if (pant == 1)
            {
                PageTitle.Text="";
                pant = 0;
            }

            if (op == 6)
            {
                PageTitle.Text = "";
                resultado = (float)0.0;
                op = 0;
            }

            PageTitle.Text = PageTitle.Text + boton.Content.ToString();


        }

        private void reset(object sender, RoutedEventArgs e)
        {
            resultado = (float)0.0;
            PageTitle.Text = "0.0";
            numero1 = (float)0.0;
            temp = 0;
            pant = 1;
            op = 0;
        }

        private void restar(object sender, RoutedEventArgs e)
        {
            enable++;
            if (enable == 1)
            {
                actualizarResultado();
                op = 2;
                pant = 1;
            }
            else
            {
                op = 2;
                resultado = float.Parse(PageTitle.Text);//to.string();
            }

        }

        private void dividir(object sender, RoutedEventArgs e)
        {
            enable++;
            if (enable == 1)
            {
                actualizarResultado();
                op = 4;
                pant = 1;
            }
            else
            {
                op = 4;
                resultado = float.Parse(PageTitle.Text);//to.string();
            }

        }

        private void multiplicar(object sender, RoutedEventArgs e)
        {
            enable++;
            if (enable == 1)
            {
                actualizarResultado();
                op = 3;
                pant = 1;
            }
            else
            {
                op = 3;
                resultado = float.Parse(PageTitle.Text);//to.string();
            }
        }

        private void suma(object sender, RoutedEventArgs e)
        {
            enable++;
            if (enable == 1)
            {
                actualizarResultado();
                op = 1;
                pant = 1;
            }
            else
            {
                resultado = float.Parse(PageTitle.Text);
                op = 1;
            }

        }

        private void igual(object sender, RoutedEventArgs e)
        {
            if (enable != 0)
                resultado = float.Parse(PageTitle.Text);//to.string();
            else
            {
                actualizarResultado();
                pant = 1;
            }
            op = 6;
        }

        void actualizarResultado()
        {
            numero1 = float.Parse(PageTitle.Text);//to.string();

            if (op == 1)
            {
                resultado = resultado + numero1;
            }
            if (op == 2)
            {
                resultado = resultado - numero1;
            }
            if (op == 3)
            {
                resultado = resultado * numero1;
            }
            if (op == 4)
            {
                
                resultado = resultado / numero1;
            }

            if (op == 0)

                resultado = float.Parse(PageTitle.Text);//to.string();

            PageTitle.Text = resultado + "";
            
        }




    }
}