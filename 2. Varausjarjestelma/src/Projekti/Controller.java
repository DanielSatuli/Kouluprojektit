package Projekti;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.*;
import javafx.fxml.Initializable;
import java.net.URL;
import java.util.ResourceBundle;

public class Controller implements Initializable {
    //Tabit
    @FXML
    private Tab tabHaku;
    @FXML
    private Tab tabMökki;
    @FXML
    private Tab tabKalenteri;
    @FXML
    private Tab tabAsiakas;
    @FXML
    private Tab tabPalvelut;
    //Napit
    @FXML
    private Button btnTallenna;
    @FXML
    private Button btnMuokkaa;
    //Tekstialueet
    @FXML
    private TextArea taVarustelu;
    @FXML
    private TextArea taKuvaus;
    //Tekstikentät
    @FXML
    private TextField tfID;
    @FXML
    private TextField tfAlue;
    @FXML
    private TextField tfNimi;







    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {

    }

    public void Tallenna(ActionEvent actionEvent) {
    }
}
