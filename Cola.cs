/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 30/8/2025
 * Hora: 13:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica_2
{
	/// <summary>
	/// Description of Cola.
	/// </summary>
	public class Cola : IColeccionable
	{
		private List<IComparable> numeros;
		private int indice;
		
		
		public Cola()
		{
			this.numeros = new List<IComparable>();
			primero();
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
			this.numeros.Add(c);
			
		}
		
		public bool contiene(IComparable c){
			foreach(IComparable numero in this.numeros){
				if(numero.sosIgual(c)){
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
