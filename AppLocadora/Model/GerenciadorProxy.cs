﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLocadora.Model
{
    public class GerenciadorProxy
    {
        public bool Active { get; set; }

        /// <summary>
        /// 192.168.21.130
        /// </summary>
        public string Endereco { get; set; }

        /// <summary>
        /// 8080
        /// </summary>
        public string Porta { get; set; }
    }
}
