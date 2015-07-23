<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">


    <html>
      <body>
        <h3> Persons</h3>
        <table border="1">
          <tr>
            <th colspan="2">
              <b>Name</b>
            </th>
            <th colspan="3">
              <b>Credentials</b>
            </th>
            <th colspan="3">
              <b>Phone</b>
            </th>
            <th>
              <b>Category</b>
            </th>
          </tr>
          <tr>
            <td >
              <b>FirstName</b>
            </td>
            <td >
              <b>LastName</b>
            </td>
            <td >
              <b>ID</b>
            </td>
            <td colspan="2">
              <b>Password</b>
            </td>
            <td >
              <b>Work</b>
            </td>
            <td colspan="2">
              <b>Cell</b>
            </td>
            <td >
             
            </td>

          </tr>

          <xsl:for-each select="Persons/Person">
            <tr>
              <td>
                <xsl:value-of select="Name/First"/>
              </td>
              <td>
                <xsl:value-of select="Name/Last"/>
              </td>

              <td>
                <xsl:value-of select="Credentials/Id"/>
              </td>
              <td>
                <xsl:value-of select="Credentials/Password"/>
              </td>
              <td>
                <xsl:value-of select="Phone/Cell/@Encryption"/>
              </td>

              <td>
                <xsl:value-of select="Phone/Work"/>
              </td>
              <td>
                <xsl:value-of select="Phone/Cell"/>
              </td>
              <td>
                <xsl:value-of select="Phone/Cell/@Provider"/>
              </td>

              <td>
                <xsl:value-of select="Category"/>
              </td>
              


            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
