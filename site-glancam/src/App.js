import './App.css';
import Header from './header/Header'
import Introduction from './introduction/Introduction'
import Servicos from './servicos/Servicos'
import Portifolio from './portifolio/Portifolio'
import Contato from './contato/Contato'
import Slogan from './slogan/Slogan'
import React from 'react'

function App() {
  return(
    <>
      <Header/>
      <Introduction/>
      <Servicos/>
      <Portifolio/>
      <Contato />
      <Slogan/>
    </>
  )
}

export default App;
