export const ACTION_TYPES = {
    INCREMENTAR: "@contador/INCREMENTAR",
    DECREMENTAR: "@contador/DECREMENTAR",
    REINICIAR: "@contador/REINICIAR",
    CAMBIARVALOR: "@contador/CAMBIARVALOR"
}

export const INCREMENTAR = () => ({ type: ACTION_TYPES.INCREMENTAR });
export const DECREMENTAR = () => ({ type: ACTION_TYPES.DECREMENTAR });
export const REINICIAR = () => ({ type: ACTION_TYPES.REINICIAR });
export const CAMBIARVALOR = (nuevovalor) => ({ type: ACTION_TYPES.CAMBIARVALOR, valor: nuevovalor });