using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Recursividad.Clases
{

    class TorresHannoi
    {

        public string Movimientos { get;  set; }

        public TorresHannoi()
        {
            Movimientos = string.Empty;
        }

        public int CalcularMovimientos(int discos)
        {
            if (discos == 1)
            {
                return 1; // Caso base: un solo disco requiere un movimiento
            }

            else if (discos == 0)
            {
                MessageBox.Show("Agrega algún disco"); //Condicion en caso de que sean 0 discos
                return 0;

            }
            else
            {
                return 2 * CalcularMovimientos(discos - 1) + 1; // Fórmula recursiva
            }
        }

        public void ResolverHanoi(int discos, string origen, string destino, string auxiliar)
        {
            if (discos == 1)
            {
                Movimientos += $"Mover disco de {origen} a {destino}\n";
            }

            if (discos == 0)
            {

            }
            else
            {
                ResolverHanoi(discos - 1, origen, auxiliar, destino);
                Movimientos += $"Mover disco de {origen} a {destino}\n";
                ResolverHanoi(discos - 1, auxiliar, destino, origen);
            }
        }
    }
    }

