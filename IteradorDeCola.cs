/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 26/9/2025
 * Hora: 19:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of IteradorDeCola.
	/// </summary>
	public class IteradorDeCola: Iterador
	{
		private int indice;
		private Cola c;
		
		public IteradorDeCola(Cola c)
		{
			this.c = c;
			this.primero();
		}
		
		public IComparable actual()
        {
            return c.getElementos()[indice];
        }

        public bool fin()
        {
            return this.indice >= c.cuantos();
        }

        public void primero()
        {
            this.indice = 0;
        }

        public void siguiente()
        {
            this.indice++;
        }
		
	}
}
