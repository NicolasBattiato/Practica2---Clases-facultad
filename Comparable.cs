/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 25/8/2025
 * Hora: 17:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of Comparable.
	/// </summary>
	public interface IComparable
	{
		bool sosIgual(IComparable c);
		bool sosMenor(IComparable c);
		bool sosMayor(IComparable c);
		
	}
}
