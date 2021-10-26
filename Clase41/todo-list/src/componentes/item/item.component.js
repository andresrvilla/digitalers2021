import React from 'react';

class Item extends React.Component {

    constructor(props) {
        super(props);
        this.valor = props.valor;
    }

    componentDidMount() {
        console.log("Se termino de mostrar el componente en el navegador");
    }

    render() {
        return <>
            <span style={{ textDecoration: this.props.comprado ? "line-through" : "none" }}>{this.valor}</span>
            <button onClick={() => this.props.onQuitar(this.valor)} disabled={this.props.comprado}>Quitar</button>
            <br />
        </>
    }
}

export default Item;