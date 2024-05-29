import { SinglePageDemoTemplatePage } from './app.po';

describe('SinglePageDemo App', function() {
  let page: SinglePageDemoTemplatePage;

  beforeEach(() => {
    page = new SinglePageDemoTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
