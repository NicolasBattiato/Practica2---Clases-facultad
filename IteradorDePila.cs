/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 26/9/2025
 * Hora: 19:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of IteradorDePila.
	/// </summary>
	public class IteradorDePila: Iterador
	{
		private int indice;
		private Pila p;
		public IteradorDePila(Pila p){
			this.p = p;
			this.primero();
		}
		
		public IComparable actual()
		{
			return p.getElementos()[indice];
		}
		
		public bool fin()
        {
            return this.indice >= p.cuantos();
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
