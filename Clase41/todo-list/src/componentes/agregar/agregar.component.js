import { useState } from 'react';

export default function Agregar(props) {

    const [texto, setTexto] = useState("");

    return <>
        <input type="text" onChange={(e) => setTexto(e.target.value)} value={texto}></input>
        <button onClick={() => {
            if (texto != "") {
                props.onAgregar(texto);
                setTexto("");
            }
        }}>Agregar</button>
    </>
}