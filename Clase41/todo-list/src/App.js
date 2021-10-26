import React from 'react';
import './App.css';
import Agregar from './componentes/agregar/agregar.component';
import Busqueda from './componentes/busqueda/busqueda.component';
import Encabezado from './componentes/encabezado/encabezado.component'
import Item from './componentes/item/item.component';
import Lista from './componentes/lista/lista.component';

class App extends React.Component {

  constructor(props) {
    super(props);
    this.state = {
      items: [
        {
          valor: "Leche",
          comprado: false
        },
        {
          valor: "Galletitas",
          comprado: false
        },
        {
          valor: "Manteca",
          comprado: false
        },
        {
          valor: "Fideos",
          comprado: false
        },
        {
          valor: "Picadillo",
          comprado: false
        }
      ],
      filtro: ""
    }
  }

  busqueda = (texto) => {
    this.setState({ filtro: texto });
    console.log(this.filtro);
  }

  onAgregar = (texto) => {
    this.state.items.push({ valor: texto, comprado: false })
    this.setState({
      items: this.state.items
    })
  }

  onQuitar = (item) => {
    this.setState({
      items: this.state.items.map(i => ({ valor: i.valor, comprado: i.comprado || i.valor == item }))
    })
  }

  render() {
    return (
      <div className="App">
        <Encabezado />
        <Busqueda callback={this.busqueda} />
        <Lista items={this.state.items} filtro={this.state.filtro} onQuitar={this.onQuitar} ></Lista>
        <Agregar onAgregar={this.onAgregar} />
      </div>
    );
  }


}

export default App;
