//Nome : Keven Rodrigo dos Santos Escovedo


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios1a6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //2) Escreva uma função recursiva, potencia(x, y), que devolva x elevado a potência y.
        int functioncaculatePotencia(int basepot, int expoentepot, int increment)
        {
            if (increment <  expoentepot)
            {
                return functioncaculatePotencia(basepot, expoentepot, increment + 1) * basepot;
            }
            else
            {
                return basepot;
            }
        }
        private void BT_proocessa_potencia_Click(object sender, EventArgs e)

        {
            LB_resultados.Items.Clear();
            int basepot;
            int expoentepot;
            int result;
            int increment = 1;
            basepot = Convert.ToInt32(TB_base.Text);
            expoentepot = Convert.ToInt32(TB_expoente.Text);
         result =  functioncaculatePotencia(basepot, expoentepot, increment);
            LB_resultados.Items.Add(result);

        }
        //3) Implemente uma versão recursiva da seguinte função:
        //void cubos (int n)
        //{
       // (int i = 1; i <= n; i++)
      //exibe i * i* i;
     //  }


    void calculateCubos(int n, int increment)
        {
            if(increment <= n) 
            {
                
                LB_resultados.Items.Add(increment * increment * increment);
                calculateCubos(n, increment + 1);






            }
          
        }
      

        private void BT_processar_cubos_Click(object sender, EventArgs e)
        {
            LB_resultados.Items.Clear();
            int n;
            int increment = 1;
            n = Convert.ToInt32(TB_n.Text);
            calculateCubos(n, increment);
        }
        //4) Baseado no algoritmo de Euclides, implemente uma função recursiva para determinar o máximo divisor comum (mdc) 
        //entre dois números inteiros x e y.
        //Algoritmo de Euclides:
        //se(x = y) retorna x
        //senão se(x<y) retorna mdc(y, x)
        //senão retorna mdc(x - y, y)

        int caulcalateMdc(int x, int y)
        {
            if (x == y)
            {
                return x;
            }
            else if (x < y)
            {
                return caulcalateMdc(y, x);

            }
            else
            {
                return caulcalateMdc(x - y, y);
            }

        }
        
       
        private void BT_processamdc_Click(object sender, EventArgs e)
        {
            LB_resultados.Items.Clear();
            int x;
            int y;
            int minimodivisorcomum;
            x = Convert.ToInt32(TB_x.Text);
            y = Convert.ToInt32(TB_y.Text);

            minimodivisorcomum = caulcalateMdc(x,y);
            LB_resultados.Items.Add(minimodivisorcomum);
          
        }
        //5) A Série de Fibonacci pode ser definida da seguinte maneira:
        //se(n == 0 ou n == 1) retorna n
        //se(n >= 2) retorna fib(n – 1) + fib(n – 2)
        //Seja fib(n) uma função que retorna o n-ésimo termo da série de Fibonacci, 
        //implemente uma versão recursiva e outra iterativa. Observe que a partir de um determinado número, 
        //a função recursiva começa a ficar mais lenta que a iterativa.
        int calculateFibonnacci(int numero)
        {
            if(numero == 0 || numero == 1)
            {
                return numero;
            }
            else
            {
                return calculateFibonnacci(numero - 1) + calculateFibonnacci(numero - 2);
            }
            
        }
        private void BT_processafibonacci_Click(object sender, EventArgs e)
        {
            LB_resultados.Items.Clear();
            int numeroFibonacci;
            int result;
            numeroFibonacci = Convert.ToInt32(TB_nfibonacci.Text);
            result = calculateFibonnacci(numeroFibonacci);
            LB_resultados.Items.Add(result);





        }
        // 6) Defina uma função recursiva que converte um número inteiro para a base binária.
        void calculateInteiroparaBinario(int nI)
        {
            if(nI > 0)
            {
                
                calculateInteiroparaBinario(nI / 2);
                LB_resultados.Items.Add(nI % 2);
               

            }
            
           
           
        } 

        private void BT_processarCoverterparaBinario_Click(object sender, EventArgs e)
        {
            LB_resultados.Items.Clear();
            int numeroInteiro;
            int result;
            numeroInteiro = Convert.ToInt32(TB_numeroInteiro.Text);
            calculateInteiroparaBinario(numeroInteiro);
           

        }

        
    }
  

}
