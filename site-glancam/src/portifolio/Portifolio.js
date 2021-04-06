import React from 'react'
import SetaE from './imgs/SetaGlancamE.svg'
import SetaD from './imgs/SetaGlancamD.svg'
import Port1 from './imgs/port1.png'
import Port2 from './imgs/port2.png'
import Port3 from './imgs/port3.png'
import './Portifolio.css'

const Portifolio = () => {
  return (
    <div className="portifolio">
      <h1>&lt;PORTIFÓLIO/&gt;</h1>
        <div className="grid">
          <div className="seta">
            <img src={SetaE} alt="<"/>
          </div>
          <div className="grid-port">
            <div className="port1">
              <img src={Port1} alt="Site Claoto Home"/>
            </div>
            <div className="port2">
              <img src={Port2} alt="Site Claoto Quem Somos"/>
            </div>
            <div className="port3">
              <img src={Port3} alt="Site Claoto Contato"/>
            </div>
          </div>
          <div className="seta">
            <img src={SetaD} alt=">"/>
          </div>
        </div>
          <div className="botoes1">
          <btn2></btn2>
          <btn2></btn2>
          <btn2></btn2>
          <btn2></btn2>
         </div>
        <div className="btn2">
          <a href="/g.html">PEÇA SEU ORÇAMENTO</a>
        </div>
      </div>
  )
}

export default Portifolio
