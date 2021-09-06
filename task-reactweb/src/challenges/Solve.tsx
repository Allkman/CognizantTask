import { Form, Formik, FormikHelpers } from "formik";
import { rootObjectCard } from "./Solve.model";

export default function solveSolution(props: rootObjectProps ) {

    
    const handleSubmit = (e:
        { preventDefault: () => void; }) => {
        e.preventDefault();
    
    const object: rootObjectCard = { 
        clientId: "8d0d5d459d0a4e60932ea4ae64e7dbc5",
        clientSecret: "2da8ea6a183736630a6f8aef5f8253a70bcf2c32fb0a741c6353ee3d2c5d4bdf",
        script: "",
        stdin: "",
        language: "csharp",
        versionIndex: "0",};
    
    const requestOptions = {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify(object),
    };
    
    fetch("https://api.jdoodle.com/v1/execute", requestOptions)
      .then(response => response.json())
      .then(res => console.log(res));
};
    return (
        <>
        <Formik initialValues={props.model} onSubmit={props.onSubmit}>
        
            <Form>
            <button className="btn btn-primary" type="submit" onClick={handleSubmit}>SOLVE</button>
            </Form>
        
            </Formik>
        </>
    )

}
interface rootObjectProps {
    model: rootObjectCard;
    children: string;
    onSubmit(values: rootObjectCard, action: FormikHelpers<rootObjectCard>) : void;
}