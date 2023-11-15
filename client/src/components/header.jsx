import React from 'react'
import {Link} from 'react-router-dom'

export const Header = () => {
  return (
    <header>
      <h1>Banco Zarpado</h1>
      <div class="buttons">
          <button id="iniciarSesion">Iniciar Sesión</button>
          <button id="registrarse">Registrarse</button>
      </div>
    </header>
  )
}
