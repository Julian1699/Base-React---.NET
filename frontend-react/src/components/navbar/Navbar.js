import React from 'react';
import { Link } from 'react-router-dom';
import '@fortawesome/fontawesome-free/css/all.min.css';
import '../../styles/App.css'; // Asegúrate de importar App.css desde la ubicación correcta

import reactLogo from '../../assets/images/react-logo.png';
import dotnetLogo from '../../assets/images/dotnet-logo.png'; // Cambiado a dotnet-logo

export default function Navbar() {
  return (
    <div className='container'>
      <nav className="navbar navbar-expand-lg navbar-dark bg-primary">
        <div className="container-fluid">
          <Link to="/" className="navbar-brand d-flex align-items-center">
            <img src={reactLogo} alt="React Logo" className="logo logo-bg-white" />
            <img src={dotnetLogo} alt="DotNet Logo" className="logo logo-bg-white" />
            <span>Sistema de Objetos</span>
          </Link>
          <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span className="navbar-toggler-icon"></span>
          </button>
          <div className="collapse navbar-collapse" id="navbarNav">
            <ul className="navbar-nav ms-auto">
              <li className="nav-item">
                <Link className="nav-link active" aria-current="page" to="/"><i className="fas fa-home"></i> Inicio</Link>
              </li>
              <li className="nav-item">
                <Link className="nav-link" to="/agregar"><i className="fas fa-plus-circle"></i> Agregar Objeto</Link>
              </li>
              <li className="nav-item">
                <Link className="nav-link" to="/objetos"><i className="fas fa-list"></i> Listar Objetos</Link>
              </li>
              <li className="nav-item">
                <Link className="nav-link" to="/informacion"><i className="fas fa-info-circle"></i> Información</Link>
              </li>
              <li className="nav-item">
                <Link className="nav-link" to="/tecnologias"><i className="fas fa-cogs"></i> Tecnologías</Link>
              </li>
            </ul>
          </div>
        </div>
      </nav>
    </div>
  );
}
