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
	public class Conjunto : IColeccionable, Iterable
	{
		//List<string> conjunto = new List<string>();
		List<IComparable> conjunto;
		private int indice;
		
		public Iterador crearIterador(){
			
			return new IteradorDeConjunto(this);
		}
		
		public Conjunto()
		{
			
			conjunto = new List<IComparable>();
		}
		
		public List<IComparable> getElementos()
		{
		    return this.conjunto.Cast<IComparable>().ToList();
		}
		
		public void agregar(IComparable c){
			
			if (!pertenece(c)){
				
				conjunto.Add(c);
			}
		}
		
		public bool pertenece(IComparable c){
			
			for(int i = 0; i < this.conjunto.Count; i++){
				if (this.conjunto[i].sosIgual(c)){
					return true;
				}
			}
			return false;
			
		}
		
		public int cuantos(){
			
			return conjunto.Count;
		}
		
		public bool contiene(IComparable c){
			
			return pertenece(c);
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

	}
}
