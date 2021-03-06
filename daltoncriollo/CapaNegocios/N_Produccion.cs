﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;
using System.Data;


namespace CapaNegocios
{
    public class N_Produccion
    {

        public static DataTable Listar()
        {
            D_Produccion Datos = new D_Produccion();
            return Datos.Listar();

        }

        public static DataTable Buscar(string Valor)
        {
            D_Produccion Datos = new D_Produccion();
            return Datos.Buscar(Valor);

        }

        public static DataTable BuscarMP(int idPT, decimal requerimiento)
        {
            D_Produccion Datos = new D_Produccion();
            return Datos.BuscarMP(idPT, requerimiento);

        }

        public static DataTable SeleccionarPT()
        {
            D_Produccion Datos = new D_Produccion();
            return Datos.SeleccionarPT();

        }

        public static DataTable SeleccionarMP()
        {
            D_Produccion Datos = new D_Produccion();
            return Datos.SeleccionarMP();

        }

        public static string Insertar(int articuloprodu, int materiaprima, decimal cantidad, decimal factor, int qtyart)
        {
            D_Produccion Datos = new D_Produccion();
            E_Produccion Obj = new E_Produccion();
            Obj.articuloprodu = articuloprodu;
            Obj.materiaprima = materiaprima;
            Obj.cantidad = cantidad;
            Obj.factor = factor;
            Obj.qtyart = qtyart;
            return Datos.Insertar(Obj);

        }

        public static string Actualizar(int ideprodu, int articuloprodu, int materiaprima, decimal cantidad, decimal factor, int qtyart)
        {
            D_Produccion Datos = new D_Produccion();
            E_Produccion Obj = new E_Produccion();
            Obj.ideprodu = ideprodu;
            Obj.articuloprodu = articuloprodu;
            Obj.materiaprima = materiaprima;
            Obj.cantidad = cantidad;
            Obj.factor = factor;
            Obj.qtyart = qtyart;
            return Datos.Actualizar(Obj);
           
        }

        public static string Eliminar(int ideprodu, int articuloprodu, int materiaprima, decimal cantidad, decimal factor, int qtyart)
        {
            D_Produccion Datos = new D_Produccion();
            E_Produccion Obj = new E_Produccion();
            Obj.ideprodu = ideprodu;
            Obj.articuloprodu = articuloprodu;
            Obj.materiaprima = materiaprima;
            Obj.cantidad = cantidad;
            Obj.factor = factor;
            Obj.qtyart = qtyart;
            return Datos.Eliminar(Obj);

        }

    }
}
