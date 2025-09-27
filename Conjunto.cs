/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 11/9/2025
 * Hora: 20:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica_2
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary>
	public class Conjunto : IColeccionable, Iterador
	{
		List<string> conjunto = new List<string>();
		private int indice;
		
		public Iterador crearIterador(){
			
			return new IteradorDeConjunto(this);
		}
		
		public Conjunto()
		{
			conjunto = new List<string>();
		}
		
		public List<IComparable> getElementos()
		{
		    return this.conjunto.Cast<IComparable>().ToList();
		}
		
		public void agregar(string elem){
			
			if (!conjunto.Contains(elem)){
				
				conjunto.Add(elem);
			}
		}
		
		public bool pertenece(string elem){
			
			return conjunto.Contains(elem);
		}
		
		public int cuantos(){
			
			return conjunto.Count;
		}
		
		public IComparable minimo()
		{
			if (this.conjunto.Count == 0){
				return null;
			}
			IComparable minimo = this.conjunto[0];
			foreach (IComparable elem in this.conjunto){
				if (elem.sosMenor(minimo)){
					minimo = elem;
				}
			}
			return minimo;
		}
		
		public IComparable maximo()
		{
			if (this.conjunto.Count == 0){
				return null;
			}
			IComparable maximo = this.conjunto[0];
			foreach (IComparable elem in this.conjunto){
				if (elem.sosMayor(maximo)){
					maximo = elem;
				}
			}
			return maximo;
		}
		
		public void agregar(IComparable c)
		{
			
		}
		
		public bool contiene(IComparable c)
		{
			return true;
		}
		
		public void primero(){
			
			if (this.conjunto.Count > 0)
        	{
            	this.indice = 0;
        	}
		}
		
		public void siguiente(){
			
			if (this.indice < this.conjunto.Count - 1)
        	{
            	this.indice++;
        	}
		}
		
		public bool fin(){
			
			return this.indice >= this.conjunto.Count;
		}
		// REVISAR
		public IComparable actual()
		{
		    return (IComparable)this.conjunto[indice];
		}
	}
}
