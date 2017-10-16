
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
      <html>
        <body>
          <h2>Pizza UTN</h2>
          <table border="1">
            
            <tr bgcolor="#9acd32">
              <th>Orden de Compra</th>
            </tr>
            <table border="1">
              <tr>
                <td>Cantidad</td>
                <td>
                  <xsl:value-of select="ORDEN/PIZZA/CANTIDAD"/>
                </td>
              </tr>

              <tr>
                <td>Tipo</td>
                <td>
                  <xsl:value-of select="ORDEN/PIZZA/TIPO"/>
                </td>
              </tr>

              <tr>
                <td>Pasta</td>
                <td>
                  <xsl:value-of select="ORDEN/PIZZA/PASTA"/>
                </td>
              </tr>

              <tr>
                <td>Tamaño</td>
                <td>
                  <xsl:value-of select="ORDEN/PIZZA/TAMANNO"/>
                </td>
              </tr>
            </table>

            <table border="1">
              <tr bgcolor="#9acd32">
                <th>Extras</th>
              </tr>
              <tr>
                <xsl:for-each select="ORDEN/ADICIONALES/EXTRAS">
                  <tr>
                    <td>
                      <xsl:value-of select="./@NOMBRE"/>
                    </td>
                    <td>
                      <xsl:value-of select="."/>
                    </td>
                  </tr>
                </xsl:for-each>
              </tr>

              <tr>
                <td>Total</td>
                <td>
                  <xsl:value-of select="ORDEN/TOTAL"/>
                </td>
              </tr>
            </table>           
            
          </table>
        </body>
      </html>
        
    </xsl:template>
</xsl:stylesheet>
