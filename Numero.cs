/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 25/8/2025
 * Hora: 17:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of Numero.
	/// </summary>
	public class Numero : IComparable
	{
		private int valor;
		
		public Numero(int valor)
		{
			this.valor = valor;
		}
		
		public int getValor()
		{
			return valor;
		}
		
		public void setValor(int valor)
		{
			this.valor = valor;
		}
		
		public bool sosIgual(IComparable c)
		{
			return valor == ((Numero)c).getValor();
		}
		
		public bool sosMayor(IComparable c)
		{
			return valor > ((Numero)c).getValor();
		}
		
		public bool sosMenor(IComparable c)
		{
			return valor < ((Numero)c).getValor();
		}
		
		public override string ToString()
		{
		    return this.valor.ToString();
		}
		
		
		
		
	}
}
