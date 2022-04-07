using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//2. Crear las variables necesarias para ingresar por
//Inspector el precio de 3 productos y un monto de dinero
//disponible.Comunicar si la suma de los mismos supera o
//no el monto de dinero disponible.Luego indicar cuánto 
//dinero sobra o falta.
public class Ej02 : MonoBehaviour
{
    public float producto1;
    public float producto2;
    public float producto3;
    public float monto;
    // Start is called before the first frame update
    void Start()
    {
        float total;
        float plata;
        total = producto1 + producto2 + producto3;
        if (total > monto)
        {
            plata = total - monto;
            Debug.Log("Faltan $" + plata + " para pagar los 3 productos");
        }
        else if (total < monto)
        {
            plata = monto - total;
            Debug.Log("Sobran $" + plata + " del monto para pagar los 3 productos");
        }
        else if(total == monto){
            Debug.Log("Tenés el total exacto de dinero para pagar los 3 productos");
        }
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
