using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;

namespace negocios
{
    public class cls_negocios
    {
        cls_conex ConexCls = new cls_conex();

        public int IdDireccion;
        public string tipo_direccion;
        public string linea1;
        public int apartado_postal;
        public float monto;
        public int id_provincia;
        public int id_pais;
        public int id_cliente;

        public int IdDireccion1 {
            get => IdDireccion;
            set => IdDireccion = value;
        }
        public string Tipo_direccion {
            get => tipo_direccion;
            set => tipo_direccion = value;
        }
        public string Linea1 {
            get => linea1;
            set => linea1 = value;
        }
        public int Apartado_postal {
            get => apartado_postal;
            set => apartado_postal = value;
        }
        public float Monto {
            get => monto;
            set => monto = value;
        }
        public int Id_provincia {
            get => id_provincia;
            set => id_provincia = value;
        }
        public int Id_pais {
            get => id_pais;
            set => id_pais = value;
        }
        public int Id_cliente {
            get => id_cliente;
            set => id_cliente = value;
        }

        public DataTable GetDir()
        {

            return ConexCls.GetDireccion(IdDireccion);
        }

        public bool AgregarCliente()
        {
            bool ini = true;

            if (ini == true)
            {
                ConexCls.IngDireccion(IdDireccion, Tipo_direccion, Linea1, Apartado_postal, Monto, Id_provincia, Id_pais, Id_cliente);

            }
            return false;

        }

    }
}
