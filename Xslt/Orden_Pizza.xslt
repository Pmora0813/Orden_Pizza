
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
      <html>
        <body>
          <h2>Pizza UTn</h2>
          <table border="1">
            <tr bgcolor="#9acd32">
              <th>Orden de Compra</th>
            </tr>
            <tr> 
            <td>Cantidad</td>
            <td>
              <xsl:value-of select="ORDEN/CANTIDAD"/>
            </td>
            </tr>
            
            <tr>
              <td>Tipo</td>
              <td>
                <xsl:value-of select="ORDEN/TIPO"/>
              </td>
            </tr>

            <tr>
              <td>Pasta</td>
              <td>
                <xsl:value-of select="ORDEN/PASTA"/>
              </td>
            </tr>
            
            <tr>
              <td>Tamanno</td>
              <td>
                <xsl:value-of select="ORDEN/TAMANNO"/>
              </td>
            </tr>

            <th>Extras</th>
            <tr>
              <xsl:for-each select="ORDEN/ADICIONALES/EXTRAS">
                
              </xsl:for-each>
            </tr>

            <tr>
              <td>TOTAL</td>
              <td>
                <xsl:value-of select="ORDEN/TOTAL"/>
              </td>
            </tr>
            
          </table>
        </body>
      </html>
        
    </xsl:template>
</xsl:stylesheet>
