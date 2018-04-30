using DevExpress.Xpo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATRCBASE.BL 
{
    public class UnidadDeTrabajo : UnitOfWork
    {
        //private Usuario usuario;
        private Hashtable tableOfNewObjects;

        /// <summary>
        /// Crea una unidad de trabajo con las opciones predeterminadas
        /// </summary>
        /// <returns></returns>
        /// 
        public UnidadDeTrabajo()
        {
            this.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists;
            //Init();
            //Debido a cuestiones de performance, la insercion de logs sera manual, no descomentar la linea de arriba
        }

        public UnidadDeTrabajo(IDataLayer layer)
            : base(layer)
        {
        }
        public static UnidadDeTrabajo ObtenerUnidad()
        {
            UnidadDeTrabajo unidad = UtileriasXPO.ObtenerNuevaUnidadDeTrabajo();
            return unidad;
        }
        /// <summary>
        /// Inicializa la unidad de trabajo
        /// </summary>
        private void Init()
        {
            //usuario = Utilerias.UsuarioActual;
            tableOfNewObjects = new Hashtable();

            this.ObjectDeleted += new ObjectManipulationEventHandler(LogUnidad_ObjectDeleted);
            this.ObjectSaving += new ObjectManipulationEventHandler(LogUnidad_ObjectSaving);
            this.ObjectSaved += new ObjectManipulationEventHandler(LogUnidad_ObjectSaved);
        }

        void LogUnidad_ObjectSaved(object sender, ObjectManipulationEventArgs e)
        {
            ATRCBase obj = (ATRCBase)e.Object;
            if (!obj.IsDeleted)
            {
                if (tableOfNewObjects.Contains(obj))
                {
                    tableOfNewObjects.Remove(obj);
                }
            }
        }

        void LogUnidad_ObjectSaving(object sender, ObjectManipulationEventArgs e)
        {
            ATRCBase obj = (ATRCBase)e.Object;
            if (!obj.IsDeleted)
                if (obj.Oid < 1)
                    tableOfNewObjects[obj] = obj;
        }

        void LogUnidad_ObjectDeleted(object sender, ObjectManipulationEventArgs e)
        {
            ATRCBase obj = (ATRCBase)e.Object;
        }
    }
}

