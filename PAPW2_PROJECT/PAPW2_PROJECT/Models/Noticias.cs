﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAPW2_PROJECT.Models
{
    public class Noticias
    {
        public int iD_Noticia { get; set; }

        public int paisF { get; set; }

        public int ciudadF { get; set; }

        public int coloniaF { get; set; }

        public DateTime fecha_Hora_Acontecimiento { get; set; }

        public DateTime fecha_Publicacion { get; set; }

        public int autor { get; set; }

        public string titulo_Noticia { get; set; }

        public string descripcion_Noticia { get; set; }

        public string texto_Noticia { get; set; }

        public string palabra_Clave { get; set; }

        public int seccion_Noticia { get; set; }

        public int estatus_Noticia { get; set; }

        public int likes { get; set; }

        public int visitas { get; set; }

        public string comentarios_editor { get; set; } //no sigue el formato de nombres, tampoco en sql

        public virtual Secciones Secciones { get; set; }

        public virtual Estatus Estatus { get; set; }

        public virtual Paises Paises { get; set; }

        public virtual Ciudades Ciudades { get; set; }

        public virtual Colonias Colonias { get; set; }

        public virtual Usuarios Usuarios { get; set; }

    }
}
