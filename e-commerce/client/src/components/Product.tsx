import { IProduct } from "../model/IProduct";

interface Props{
  product: IProduct
}


export default function Product({product}: Props){
    return(
      <>
        {product.isActive ? (
          <div>
            <h2>{product.name}</h2>
            <p> {product.price}</p>
         </div>
        ): <p>Ürün satışta değil.</p>
        }
      </>
    );
  }