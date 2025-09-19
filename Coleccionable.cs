/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 26/8/2025
 * Hora: 18:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica_2
{
	/// <summary>
	/// Description of Coleccionable.
	/// </summary>
	public interface IColeccionable
	{
		
		int cuantos();
		IComparable minimo();
		IComparable maximo();
		void agregar(IComparable c);
		bool contiene(IComparable c);
		
		
	}
}
