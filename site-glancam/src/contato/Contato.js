import './Contato.css'
import React from 'react'
import logo from './imgs/logo-glancam-lar-amar.svg'
import whats from './imgs/whatsapp.svg'
import smart from './imgs/smartphone.svg'
import email from './imgs/email.svg'
import location from './imgs/location.svg'

const Contato = () => {
  return (
    <div>
    <div>
       <h1>&lt;ENTRE EM CONTATO/&gt;</h1>
       <div className="alinhamento">
        <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d467689.7971515349!2d-46.875484848345295!3d-23.682160400954345!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce448183a461d1%3A0x9ba94b08ff335bae!2zU8OjbyBQYXVsbywgU1A!5e0!3m2!1spt-BR!2sbr!4v1611326317674!5m2!1spt-BR!2sbr" title="mapa"></iframe>
        <div className="gridcal">
          <div><img src={logo} alt="<GLANCAM/>"/></div>
          <div className="whats">
            <img src={whats} alt="<WHATSAPP/>"/>
            <p>+55 (11) 94154-5719</p>
          </div>
          <div className="whats">
            <img src={smart} alt="<WHATSAPP/>"/>
            <p>+55 (11) 94571-4697</p>
          </div>
          <div className="whats">
            <img src={email} alt="<WHATSAPP/>"/>
            <p>glancam.webdev@gmail.com</p>
          </div>
          <div className="whats">
            <img src={location} alt="<WHATSAPP/>"/>
            <p>Tv. Pe. Anchieta, 82 - Vila Jordanópolis - SBC</p>
          </div>
        </div>
      </div>
    </div>
    <div className="btn-saiba-mais">
        <a href="./saibamais.html">PEÇA JÁ SEU ORÇAMENTO</a>
      </div>
    </div>
  )
}

export default Contato
