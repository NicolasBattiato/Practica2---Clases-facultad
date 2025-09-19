/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 30/8/2025
 * Hora: 22:05
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica_2
{
	/// <summary>
	/// Description of ColeccionMultiple.
	/// </summary>
	public class IColeccionMultiple : IColeccionable
	{
		private Pila pila;
		private Cola cola;
			
		public IColeccionMultiple(Pila p, Cola c)
		{
			this.pila = p;
			this.cola = c;
		}
		
		// Implementar funciones de Coleccionables
		
		public int cuantos(){
			return this.pila.cuantos() + this.cola.cuantos();
			
		}
		
		public IComparable minimo(){
			
			IComparable minimoPila = this.pila.minimo();
			IComparable minimoCola = this.cola.minimo();
			
			if(minimoPila == null && minimoCola == null){
				return null;
			}
			else if (minimoPila == null){
				return minimoCola;
			}
			else if(minimoCola == null){
				return minimoPila;
			}
			
			else{
				return minimoPila.sosMenor(minimoCola) ? minimoPila : minimoCola;
			}
			
		}
		
		public IComparable maximo(){
			
			IComparable maximoPila = this.pila.maximo();
			IComparable maximoCola = this.cola.maximo();
			
			if(maximoPila == null && maximoCola == null){
				return null;
			}
			else if (maximoPila == null){
				return maximoCola;
			}
			else if(maximoCola == null){
				return maximoPila;
			}
			
			else{
				return maximoPila.sosMayor(maximoCola) ? maximoPila : maximoCola;
			}
			
			
		}
		
		public void agregar(IComparable c){
			
		}
		
		public bool contiene(IComparable c){
			
			return this.pila.contiene(c) || this.cola.contiene(c);
		}
		
		
	}
}
