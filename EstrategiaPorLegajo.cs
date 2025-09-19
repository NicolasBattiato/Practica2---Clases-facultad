/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 11/9/2025
 * Hora: 19:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of EstrategiaPorLegajo.
	/// </summary>
	public class EstrategiaPorLegajo : EstrategiaDeComparacion
	{
		public bool sosIgual(Alumno a, Alumno b){
			
			return a.getLegajo() == b.getLegajo();
		}
		
		public bool sosMayor(Alumno a, Alumno b){
			
			return a.getLegajo() > b.getLegajo();
		}
		
		public bool sosMenor(Alumno a, Alumno b){
			
			return a.getLegajo() < b.getLegajo();
		}
		
	}
}
