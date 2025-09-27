/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 26/8/2025
 * Hora: 18:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica_2
{
	/// <summary>
	/// Description of Pila.
	/// </summary>
	public class Pila : IColeccionable, Iterador
	{
		private List<IComparable> numeros ;
		private int indice;
		
		public Iterador crearIterador()
		{
			return new IteradorDePila(this);
		}
		
		public Pila()
		{
			this.numeros = new List<IComparable>();
			primero();
		}
		
		public List<IComparable> getElementos()
		{
		    return this.numeros;
		}
		
		public int cuantos()
		{
			return this.numeros.Count;
		}
		
		public IComparable minimo()
		{
			if (this.numeros.Count == 0){
				return null;
			}
			IComparable minimo = this.numeros[0];
			foreach (IComparable numero in this.numeros){
				if (numero.sosMenor(minimo)){
					minimo = numero;
				}
			}
			return minimo;
		}
		
		public IComparable maximo()
		{
			if (this.numeros.Count == 0){
				return null;
			}
			IComparable maximo = this.numeros[0];
			foreach (IComparable numero in this.numeros){
				if (numero.sosMayor(maximo)){
					maximo = numero;
				}
			}
			return maximo;
		}
		
		public void agregar(IComparable c)
		{
			this.numeros.Add(c); // Castear
		}
		
		public bool contiene(IComparable c)
		{
			foreach (IComparable numero in this.numeros){
				if (numero.sosIgual(c)){
					return true;
				}
			}
			return false;
		}
		
		public void primero(){
			
			if (this.numeros.Count > 0)
        	{
            	this.indice = 0;
        	}
		}
		
		public void siguiente(){
			
			if (this.indice < this.numeros.Count - 1)
        	{
            	this.indice++;
        	}
		}
		
		public bool fin(){
			
			return this.indice >= this.numeros.Count;
		}
		
		public IComparable actual()
    	{
			return this.numeros[indice];
    	} 

		
		
	}
}
