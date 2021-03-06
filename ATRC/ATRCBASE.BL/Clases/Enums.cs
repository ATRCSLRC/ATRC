﻿using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATRCBASE.BL
{
    [NonPersistent]
     public class Enums
    {
       
        public enum TipoIdentificacion
        {
            Ninguno = 0,
            Gafete = 1,
            Manual = 2
        }

        public enum TipoAplicacion
        {
            Ninguno = 0,
            Windows = 1,
            Web = 2
        }

        public enum TipoArticulo
        {
            General = 0,
            Baterias = 1,
            Llantas = 2,
            Herramienta = 3
        }

        public enum TipoMedida
        {
            Pzs = 0,
            Kg = 1,
            Gr = 2,
            Lts = 3,
            Pies = 4,
            Pulgadas = 5,
            Metros = 6,
            Cm = 7,
            Lbs = 8
        }
        public enum Destino
        {
            Unidad = 0,
            Otro = 1
        }

        public enum Recibo
        {
            Usuario = 0,
            Otro = 1
        }

        public enum EstadoSalida
        {
            Entregado = 0,
            Devuelto = 1
        }

        public enum Combustible
        {
            Ninguno = 0,
            Gasolina = 1,
            Diesel = 2,
            Gas = 3,
            Electricidad = 4
        }

        public enum Transmision
        {
            Ninguna = 0,
            Estandar = 1,
            Automatico = 2
        }

        public enum Frenos
        {
            Ninguno = 0,
            Hidraulicos = 1,
            Aire = 2,
            Otro = 3
                
        }

        public enum Suspencion
        {
            Ninguno = 0,
            Muelles = 1,
            Aire = 2, 
            Amortiguador = 3
        }

        public enum Puerta
        {
            Ninguna = 0,
            Manual = 1,
            Hidraulica = 2,
            Aire = 3
        }

        public enum ServiciosUnidad
        {
            Compostura = 0,
            [Description("Cambio de aceite")]
            CambioAceite = 1,
            Lavado = 2,
            Otro = 3,
            Preventivo = 4
        }

        public enum TipoDestino
        {
            Unidad = 0,
            Empleado = 1
        }

        public enum TipoUnidad
        {
            Camion = 0,
            Automovil = 1,
            Maquinaria = 2,
            Panel = 3,
            Micro = 4
        }

        public enum EstadoLlanta
        {
            Nueva = 0,
            Extra = 1,
            Merma = 2
        }

        public enum TipoRuta
        {
            Normal = 0,
            Entrada = 1,
            Salida = 2,
            /*Apoyo = 3,
            Especial = 4,
            Extra = 5,
            ExtraSalida = 6,
            ExtraEntrada = 7*/

        }
        public enum Turno
        {
            Primero = 0,
            Segundo = 1,
            Tercero = 2,
            Cuarto = 3
        }

        public enum EstadoExtintor
        {
            Bueno = 0,
            Vencido = 1,
            Usado = 2,
            Mantenimiento = 3
        }

        public enum UbicacionExtintor
        {
            Unidad = 0,
            Oficina = 1
        }

        public enum ReporteCombustible
        {
            Consumo = 0,
            PedidoDiesel = 1,
            UnidadDiesel = 2,
            DetallesMedidores = 3
        }

        public enum EstadoUnidad
        {
            BuenEstado = 0,
            Vendido = 1,
            [Description("Fuera de servicio")]
            FueraServicio = 2,
            Taller = 3
        }

        public enum EstadoContrato
        {
            Creado = 0,
            EnViaje = 1,
            Terminado = 2,
            Apartado = 3,
            Cancelado = 4
        }
        public enum LugarPublicar
        {
            Comedor = 0,
            Caseta = 1,
            Recepcion = 2, 
            Todas = 3,
            Rutas = 4
        }

        public enum EstadoPedidoRutas
        {
            Creado = 0,
            Enviado = 1,
            Revision = 2,
            Aprobado = 3,
            Cancelado = 4,
            Rechazado = 5,
            Pendiente = 6
        }

        public enum TipoCreacionRutas
        {  
            Creado = 0,
            Enviado = 1,
            Revicion = 2,
            Aprobado = 3,
            Cancelado = 4,
            Rechazado = 5,
            Pendiente = 6
        }

        public enum EstadoAclaraciones
        {
            Creado_Rutas = 0,
            Creado_Maquiladora = 1,
            Revision_Rutas = 2,
            Revision_Maquiladora = 3,
            Aprobada_Rutas = 4,
            Aprobada_Maquiladora = 5,
            Rechazada_Rutas = 6,
            Rechazada_Maquiladora = 7,
            Cambios_Realizados = 8
        }

        public enum TipoAcceso
        {
            Comedor = 0,
            Dormitorio = 1
        }
    }
}
