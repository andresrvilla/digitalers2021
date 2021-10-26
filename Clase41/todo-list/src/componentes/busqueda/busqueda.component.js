import { useState } from 'react';

function Busqueda(props) {
    const [texto, setTexto] = useState("");

    function textoCambia(e) {
        setTexto(e.target.value);
    }

    return <div>
        <input type="text" onChange={textoCambia} value={texto}></input>
        <button onClick={() => props.callback(texto)} >Buscar</button>
    </div>
}

export default Busqueda;