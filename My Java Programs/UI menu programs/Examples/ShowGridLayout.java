// ShowGridLayout.java: Demonstrate using GridLayout
import javax.swing.JButton;
import javax.swing.JFrame;
import java.awt.GridLayout;
import java.awt.Container;
import javax.swing.*;
import java.awt.*;

public class ShowGridLayout extends JFrame {
  /** Default constructor */

  private ImageIcon[] cardImage={
     new ImageIcon("image/burger1.gif"),
     new ImageIcon("image/3h.gif"),
     new ImageIcon("image/4h.gif"),
     new ImageIcon("image/2d.gif"),
     new ImageIcon("image/3d.gif"),
     new ImageIcon("image/4d.gif"),
     new ImageIcon("image/2h.gif"),
     new ImageIcon("image/2s.gif"),
     new ImageIcon("image/3s.gif"),
     new ImageIcon("image/4s.gif"),
     new ImageIcon("image/5s.gif")};

  private JPanel cardPanel = new JPanel();

  public ShowGridLayout() {
    // Get the content pane of the frame
    Container container = getContentPane();

    // Set GridLayout, 4 rows, 3 columns, and gaps 5 between
    // components horizontally and vertically
    cardPanel.setLayout(new FlowLayout());
cardPanel.setPreferredSize(new Dimension(300,100));
    // Add buttons to the panel:
    for (int i = 1; i <= 10; i++)
      cardPanel.add(new JButton(cardImage[i]));

    container.add(cardPanel);
  }

  /** Main method */
  public static void main(String[] args) {
    ShowGridLayout frame = new ShowGridLayout();
    frame.setTitle("Show GridLayout");
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setSize(200, 200);
    frame.setVisible(true);
  }
}