/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 13/9/2025
 * Hora: 23:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of Iterador.
	/// </summary>
	public interface Iterador
	{
		void primero();
		void siguiente();
		bool fin();
		IComparable actual();
	}
}
