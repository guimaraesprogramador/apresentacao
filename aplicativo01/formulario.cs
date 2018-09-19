using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
namespace aplicativo01
{
	
	
	public 	class formulario
	{
		Thread[] t1 = new Thread[3];
		AutoResetEvent[] are = new AutoResetEvent[3];
        public string[] texto = new string[3];
		 void exibe()
		{
			are[0] = new AutoResetEvent(false);
          
            while (true)
			{
                bool b = are[0].WaitOne(1000);
                if (b)
				{
					
					break;
				}
				MessageBox.Show(texto[0]+"trabalho");
			}
		}
		public   void criartheard(int index)
		{
			try
			{
				if (index == 0)
				{
					t1[0] = new Thread(exibe);
				}
				else if (index == 1)
				{
					t1[1] = new Thread(exibe2);
				}
				else if (index == 2)
				{
					t1[2] = new Thread(exibe3);
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
			
		}
		public  void lancar(int index)
		{
            try
            {
                switch (index)
                {
                    case 0:

                        t1[0].Start();
                        break;
                    case 1:
                        t1[1].Start();
                        break;
                    case 2:
                        t1[2].Start();
                        break;
                }
            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
			
		}
		public void parar(int index)
		{
            try
            {
                if (index == 0)
                {
                    if (t1[0].IsAlive)
                    {
                        are[0].Set();
                    }
                }
                else if (index == 1)
                {
                    if (t1[1].IsAlive)
                    {
                        are[1].Set();
                    }
                }
                else if (index == 2)
                {
                    if (t1[2].IsAlive)
                    {
                        are[2].Set();
                    }
                }
            }
            catch (Exception)
            {

            }
			
		}
		 void exibe2()
		{
			are[1] = new AutoResetEvent(false);
           
            while (true)
			{
                bool b = are[1].WaitOne(2000);

                if (b)
				{
					break;
				}
				MessageBox.Show(texto[1]);
				
			}
		}
	 void exibe3()
		{
			are[2] = new AutoResetEvent(false);
           
            while (true)
			{
                bool b = are[2].WaitOne(3000);
                if (b)
				{
					break;
				}
				MessageBox.Show(texto[2]);
			}
		}
		public void exclur(int index)
		{
            try
            {
                if (t1 != null)
                {
                    if (index == 0)
                    {
                        t1[0].Abort();
                    }
                    else if (index == 1)
                    {
                        t1[1].Abort();
                    }
                    else if (index == 2)
                    {
                        t1[2].Abort();
                    }
                }

            }
            catch (Exception)
            {

            }
		}
	}
}
