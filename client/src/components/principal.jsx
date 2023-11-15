import React from 'react'
import {Link, Outlet} from 'react-router-dom'

export const Principal = () => {
  return (
    <div className="App">
    <header>
      <h1>Banco Zarpado</h1>
      <div class="buttons">
          <button>Iniciar Sesión</button>
          <button>Registrarse</button>
      </div>
    </header>

    <main>
      <section id="banner">
          <img src="" alt="Imagen 1" class="banner-img active"/>
          <img src="" alt="Imagen 2" class="banner-img"/>
          <img src="" alt="Imagen 3" class="banner-img"/>
      </section>

      <section id="cotizacionDolar">
          <h2>Cotización del Dólar</h2>
          <p>USD/ARS: 123.45</p>
      </section>
    </main>

    <footer>
      <p>&copy; 2023 Banco Zarpado - Todos los derechos reservados</p>
    </footer>
    
  </div>
  )
}
