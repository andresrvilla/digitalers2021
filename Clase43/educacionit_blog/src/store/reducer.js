import {ACTION_TYPES} from './actions'
const { INCREMENTAR, DECREMENTAR, REINICIAR, CAMBIARVALOR } = ACTION_TYPES
/*
es equivalente a
const INCREMENTAR = ACTION_TYPES.INCREMENTAR;
const DECREMENTAR = ACTION_TYPES.DECREMENTAR;
const REINICIAR = ACTION_TYPES.REINICIAR;
const CAMBIARVALOR = ACTION_TYPES.CAMBIARVALOR;
*/

export function Reducer(estado, accion){

    switch(accion.type){
      case INCREMENTAR:
        estado.contador++;
        return estado;
      case DECREMENTAR:
        estado.contador--;
        return estado;
      case REINICIAR:
        estado.contador =0;
        return estado;
      case CAMBIARVALOR:
        estado.contador = accion.valor;
        return estado;
      default:
        return estado;
    }
  }