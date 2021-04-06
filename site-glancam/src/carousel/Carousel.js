import './Carousel.css';
import ImagemInformativo from './imgs/informativo.svg'
import ImagemPublicitario from './imgs/publicitario.svg'
import ImagemEcommerce from './imgs/e-commerce.svg'
import ImagemLogo from './imgs/logo.svg' 
import ImagemManutencao from './imgs/manutencao.svg' 
import ImagemHospedagm from './imgs/hospedagem.svg' 
import React from 'react';

const servicos = [
  { id:1 , nome: 'SITES INFORMATIVOS', imagem: ImagemInformativo },
  { id:2 , nome: 'SITES PUBLICITÁRIOS', imagem: ImagemPublicitario },
  { id:3 , nome: 'E-COMMERCE', imagem: ImagemEcommerce },
  { id:4 , nome: 'LOGOS', imagem: ImagemLogo },
  { id:5 , nome: 'MANUTENÇÃO', imagem: ImagemManutencao },
  { id:6 , nome: 'HOSPEDAGEM', imagem: ImagemHospedagm },
];

var img = 2

function alterarImagem(img){
  const imgCentral = document.querySelector("#root > div.div-servicos > ul > li:nth-child(2) > img")
  const imgDireita = document.querySelector("#root > div.div-servicos > ul > li:nth-child(3) > img")
  const imgEsquerda = document.querySelector("#root > div.div-servicos > ul > li:nth-child(1) > img")
  const legendaEsq = document.querySelector("#root > div.div-servicos > ul > li:nth-child(1) > h2")
  const legendaCen = document.querySelector("#root > div.div-servicos > ul > li:nth-child(2) > h2")
  const legendaDir = document.querySelector("#root > div.div-servicos > ul > li:nth-child(3) > h2")
  imgCentral.src=servicos.filter((servico)=> servico.id==img)[0].imagem
  imgDireita.src=servicos.filter((servico)=> servico.id==(img+1))[0].imagem
  imgEsquerda.src=servicos.filter((servico)=> servico.id==(img-1))[0].imagem
  imgCentral.alt=servicos.filter((servico)=> servico.id==img)[0].nome
  imgDireita.alt=servicos.filter((servico)=> servico.id==(img+1))[0].nome
  imgEsquerda.alt=servicos.filter((servico)=> servico.id==(img-1))[0].nome
  legendaCen.innerHTML=servicos.filter((servico)=> servico.id==img)[0].nome
  legendaDir.innerHTML=servicos.filter((servico)=> servico.id==(img+1))[0].nome
  legendaEsq.innerHTML=servicos.filter((servico)=> servico.id==(img-1))[0].nome
}

const Carousel = () => {
  return (
    <div className="div-servicos">
      <h1>&lt;NOSSOS SERVIÇOS/&gt;</h1>
      <ul>
        <li>
          <img src={ImagemInformativo} alt="Sites Informativos" />
          <h2>SITES INFORMATIVOS</h2>
        </li>
        <li>
          <img src={ImagemPublicitario} alt="Sites Publicitários" />
          <h2>SITES PUBLICITÁRIOS</h2>
        </li>
        <li>
          <img src={ImagemEcommerce} alt="E-Commerce" />
          <h2>E-COMMERCE</h2>
        </li>
      </ul>
      <div className="botoes">
        <btn onClick={()=>alterarImagem(2)}></btn>
        <btn onClick={()=>alterarImagem(3)}></btn>
        <btn onClick={()=>alterarImagem(4)}></btn>
        <btn onClick={()=>alterarImagem(5)}></btn>
      </div>
    </div>
  );
};

export default Carousel;
