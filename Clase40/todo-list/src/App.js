import './App.css';
import Busqueda from './componentes/busqueda/busqueda.component';
import Encabezado from './componentes/encabezado/encabezado.component'
import Item from './componentes/item/item.component';
import Lista from './componentes/lista/lista.component';

function App() {
  return (
    <div className="App">
      <Encabezado />
      <Busqueda />
      <Lista>
        <Item />
        <Item />
        <Item />
        <Item />
        SARAZA
      </Lista>
    </div>
  );
}

export default App;
