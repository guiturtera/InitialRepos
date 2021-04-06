import React from 'react'
import './Header.css'
import logo from './imgs/logo-glancam-lar-amar.svg'

const Header = () => {
  return (
    <header>
      <div className="logo">
        <img src={logo} alt="<GLANCAM/>"/>
      </div>
      <div className="menu">
        <nav>
          <a href="/#sobre">SOBRE</a>
          <a href="/#sobre">SERVIÇOS</a>
          <a href="/#sobre">PORTIFÓLIO</a>
          <a href="/#sobre">CONTATO</a>
        </nav>
      </div>
    </header>
  )
}

export default Header
